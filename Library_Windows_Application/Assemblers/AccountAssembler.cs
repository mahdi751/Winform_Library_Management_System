using Library_Windows_Application.DTOs;
using Library_Windows_Application.Forms;
using Library_Windows_Application.Models;
using System.Net.Http.Json;

namespace Library_Windows_Application.Assemblers
{
    public class AccountAssembler
    {

        public async Task<User?> LoginControl(LoginDTO login, Label errorlabel)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync("https://localhost:5000/api/Account/login", login);

                    if (response.IsSuccessStatusCode)
                    {
                        var user = await response.Content.ReadFromJsonAsync<User>();
                        errorlabel.Text = "";
                        return user;
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "UserNotFound":
                            case "PasswordMismatch":
                                errorlabel.Text = "Username or Password is incorrect!";
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
        public async Task<User?> RegisterControl(RegisterDTO register,Label globalError, Label userError , Label emailError)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync("https://localhost:5000/api/Account/register", register);

                    if (response.IsSuccessStatusCode)
                    {
                        User user = await response.Content.ReadFromJsonAsync<User>();

                        return user;
                    }
                    else
                    {
                        globalError.Text = "";
                        userError.Text = "";
                        emailError.Text = "";

                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "UsernameTaken":
                                userError.Text = "Username taken!";
                                break;
                            case "EmailTaken":
                                emailError.Text = "Email taken!";
                                break;
                            default:
                                globalError.Text =errorResponse.Message;
                                break;
                        }
                        return null;
                    }
                }
                catch (HttpRequestException)
                {
                    globalError.Text = "Internal connection error!";
                    return null;
                }
                catch (Exception)
                {
                    globalError.Text = "Unexpected error!";
                    return null;
                }
            }
        }

        public async Task<bool> UpdateUserInfoControl(User user,Label globalError,Label userError,Label emailError)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PutAsJsonAsync("https://localhost:5000/api/Account/Update",user);

                    if (response.IsSuccessStatusCode)
                    {
                        var success = await response.Content.ReadFromJsonAsync<bool>();

                        return success;
                    }
                    else
                    {
                        globalError.Text = "";
                        userError.Text = "";
                        emailError.Text = "";

                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "UsernameTaken":
                                userError.Text = "Username taken!";
                                break;
                            case "EmailTaken":
                                emailError.Text = "Email taken!";
                                break;
                            default:
                                globalError.Text = errorResponse.Message;
                                break;
                        }
                        return false;
                    }
                }
                catch (HttpRequestException)
                {
                    globalError.Text = "Internal connection error!";
                    return false;
                }
                catch (Exception)
                {
                    globalError.Text = "Unexpected error!";
                    return false;
                }
            }
        }

        public async Task<bool> DeleteUserControl(int userid,Label globalError)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.DeleteAsync("https://localhost:5000/api/Account/Delete/" + userid);

                    if (response.IsSuccessStatusCode)
                    {
                        var success = await response.Content.ReadFromJsonAsync<bool>();

                        return success;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (HttpRequestException)
                {
                    globalError.Text = "Internal connection error!";
                    return false;
                }
                catch (Exception)
                {
                    globalError.Text = "Unexpected error!";
                    return false;
                }
            }
        }

        public async Task<string?> GetUsernameControl(int userId)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Account/User/username/" + userId);

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
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Exception: {ex.Message}");
                return null;
            }
        }

    }
}
