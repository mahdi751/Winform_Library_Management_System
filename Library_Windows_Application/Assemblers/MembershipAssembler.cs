using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Library_Windows_Application.Assemblers
{
    public class MembershipAssembler
    {
        public async Task<Membership?> MembershipSubscriptionControl(MembershipDTO membership, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync("https://localhost:5000/api/Membership/MembershipSubscription", membership);

                    if (response.IsSuccessStatusCode)
                    {
                        var memberhsipCreated = await response.Content.ReadFromJsonAsync<Membership>();
                        
                        return memberhsipCreated;
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "MembershipCreationError":
                                errorlabel.Text = "Error Occured try again!";
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

        public async Task<Membership?> RenewMembershipSubscriptionControl(int userid, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PutAsJsonAsync("https://localhost:5000/api/Membership/RenewCurrentMembership" , userid);

                    if (response.IsSuccessStatusCode)
                    {
                        var memberhsipCreated = await response.Content.ReadFromJsonAsync<Membership>();
                        return memberhsipCreated;
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "MembershipRenewalException":
                                errorlabel.Text = "Error Occured try again!";
                                break;

                            default:
                                errorlabel.Text = errorResponse.Message;
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

        public async Task<Membership?> GetMembershipControl(int userid,Label errorLabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Membership/GetLastMembership/" + userid);

                    if (response.IsSuccessStatusCode)
                    {
                        var memberhsip = await response.Content.ReadFromJsonAsync<Membership>();
                        return memberhsip;
                    }
                    else
                    {
                        errorLabel.Text = "error Occurred!";
                        return null;
                    }
                }
                catch (HttpRequestException)
                {
                    errorLabel.Text = "Internal connection error!";
                    return null;
                }
                catch (Exception)
                {
                    errorLabel.Text = "Unxpected error!";
                    return null;
                }
            }
        }
        
        public async Task<string?> GetUsernameByMembershipID(int membershipID)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Membership/GetUsernameByMembership/" + membershipID);

                    if (response.IsSuccessStatusCode)
                    {
                        var username = await response.Content.ReadAsStringAsync();
                        return username;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (HttpRequestException)
                {
                    return null;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public async Task<int> GetMembershipRemainingBorrowAbility(int membershipID)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Membership/GetMembershipRemainingBorrowAbility/" + membershipID);

                    if (response.IsSuccessStatusCode)
                    {
                        var RemainingBorrowAbility = await response.Content.ReadFromJsonAsync<int>();
                        return RemainingBorrowAbility;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (HttpRequestException)
                {
                    return -1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
    }
}
