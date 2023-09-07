using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Library_Windows_Application.Assemblers
{
    public class ReviewAssembler
    {
        public async Task<bool> AddReviewControl(ReviewDTO review, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync("https://localhost:5000/api/Review/Create", review);

                    if (response.IsSuccessStatusCode)
                    {
                        var NewReview = await response.Content.ReadFromJsonAsync<Review>();
                        errorlabel.Text = "";

                        if (NewReview != null)
                        {
                            return true;
                        }
                        return false;
                    }
                    else
                    {
                        errorlabel.Text = "Error Occured! Try again later";
                        return false;
                    }
                }
                catch (HttpRequestException)
                {
                    errorlabel.Text = "Internal connection error!";
                    return false;
                }
                catch (Exception)
                {
                    errorlabel.Text = "Unxpected error!";
                    return false;
                }
            }
        }
        public async Task<ICollection<ReviewDetailsDTO>?> GetAllReviews(int bookid, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Review/Reviews/" + bookid);

                    if (response.IsSuccessStatusCode)
                    {
                        var reviews = await response.Content.ReadFromJsonAsync<ICollection<ReviewDetailsDTO>>();
                        errorlabel.Text = "";

                        return reviews;
                    }
                    else
                    {
                        errorlabel.Text = "Error Occured! No reviews at the moment";
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

        public async Task<int> GetBookAverageRating(int bookid)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Review/GetBookAverageRating/" + bookid);

                    if (response.IsSuccessStatusCode)
                    {
                        var reviews = await response.Content.ReadFromJsonAsync<int>();

                        return reviews;
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
