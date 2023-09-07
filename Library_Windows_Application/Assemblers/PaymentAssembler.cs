using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using System.Net.Http.Json;
using System.Windows.Forms.VisualStyles;

namespace Library_Windows_Application.Assemblers
{
    public class PaymentAssembler
    {
        public async Task<IEnumerable<OverdueBooksDetailsDTO>?> GetOverdueBookDetails(int membershipID, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Payment/GetCurrentOverduePaymentsDetails/" + membershipID);

                    if (response.IsSuccessStatusCode)
                    {
                        var overdueDetails = await response.Content.ReadFromJsonAsync<IEnumerable<OverdueBooksDetailsDTO>>();
                        return overdueDetails;
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "CalculateOverdueFinesException":
                                errorlabel.Text = "Error Occured while calculating fines!";
                                break;

                            case "GetCurrentOverduePaymentsException":
                                errorlabel.Text = "Error Occured!";
                                break;
                        }
                        return null;
                    }
                }
                catch (HttpRequestException)
                {
                    errorlabel.Text = "Internal connection error!";
                    return null;
                }
                catch (Exception)
                {
                    errorlabel.Text = "Unxpected error!";
                    return null;
                }
            }
        }

        public async Task<decimal> GetCurrentTotalOverduePayments(int membershipID, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Payment/GetCurrentTotalOverduePayments/" + membershipID);

                    if (response.IsSuccessStatusCode)
                    {
                        var overdueDetails = await response.Content.ReadFromJsonAsync<decimal>();
                            return overdueDetails;
                    }
                    else
                    {
                        errorlabel.Text = "Error Occured while calculating fines!";
                        return -1;
                    }
                }
                catch (HttpRequestException)
                {
                    errorlabel.Text = "Internal connection error!";
                    return -1;
                }
                catch (Exception)
                {
                    errorlabel.Text = "Unexpected error!";
                    return -1;
                }
            }
        }

        public async Task<PaymentHistory> PayBookFines(PaymentDTO paymentDTO, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync("https://localhost:5000/api/Payment/PayBookFines", paymentDTO);

                    if (response.IsSuccessStatusCode)
                    {
                        var payment = await response.Content.ReadFromJsonAsync<PaymentHistory>();
                        return payment;
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "PaymentHistoryException":
                                errorlabel.Text = "Couldn't complete the payment!";
                                break;
                        }
                        return null;
                    }
                }
                catch (HttpRequestException)
                {
                    errorlabel.Text = "Internal connection error!";
                    return null;
                }
                catch (Exception)
                {
                    errorlabel.Text = "Unxpected error!";
                    return null;
                }
            }
        }

        public async Task<PaymentHistory> PayAllOverdueFines(PaymentDTO paymentDTO, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync("https://localhost:5000/api/Payment/PayAllOverdueFine", paymentDTO);

                    if (response.IsSuccessStatusCode)
                    {
                        var payment = await response.Content.ReadFromJsonAsync<PaymentHistory>();
                        return payment;
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "PaymentHistoryException":
                                errorlabel.Text = "Couldn't complete the payment!";
                                break;
                        }
                        return null;
                    }
                }
                catch (HttpRequestException)
                {
                    errorlabel.Text = "Internal connection error!";
                    return null;
                }
                catch (Exception)
                {
                    errorlabel.Text = "Unxpected error!";
                    return null;
                }
            }
        }

    }
}
