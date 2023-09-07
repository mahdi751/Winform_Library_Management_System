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
    public class BookAssembler
    {
        public async Task<IEnumerable<BookDetailsDTO>?> GetBooksControl(Label globalError)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Book/Books");

                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<BookDetailsDTO> books = await response.Content.ReadFromJsonAsync<IEnumerable<BookDetailsDTO>> ();
                        return books;
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "NoBooksAvailable":
                                globalError.Text = "No books are found!";
                            break;
                        }
                        return null;
                    }
                }
            }
            catch (HttpRequestException ex)
            {

                globalError.Text = "Error Occured!";
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return null;
            }
            catch (Exception)
            {
                globalError.Text = "Internal Connection Error!";
                return null;
            }
        }
        public async Task<IEnumerable<BookDetailsDTO>?> GetBooksByTitleControl(string title,Label globalError)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Book/Books/BookTitle/" + title);

                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<BookDetailsDTO> books = await response.Content.ReadFromJsonAsync<IEnumerable<BookDetailsDTO>>();
                        return books;
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "BooksByTitleNotFound":
                                globalError.Text = "No books found for this title!";
                                break;
                        }

                        return null;
                    }
                }
            }
            catch (HttpRequestException ex)
            {

                globalError.Text = "Error Occured!";
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return null;
            }
            catch (Exception)
            {
                globalError.Text = "Internal Connection Error!";
                return null;
            }
        }
        public async Task<IEnumerable<BookDetailsDTO>?> GetBooksByAuthorNameControl(string name, Label globalError)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Book/Books/AuthorName/" + name);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<IEnumerable<BookDetailsDTO>>();
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "BooksByAuthorNameNotFound":
                                globalError.Text = "No books found for this Author!";
                                break;
                        }

                        return null;
                    }
                }
            }
            catch (HttpRequestException ex)
            {

                globalError.Text = "Error Occured!";
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return null;
            }
            catch (Exception)
            {
                globalError.Text = "Internal Connection Error!";
                return null;
            }
        }
        public async Task<IEnumerable<BookDetailsDTO>?> GetBooksByGenreControl(string genre, Label globalError)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Book/Books/BookGenre/" + genre);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<IEnumerable<BookDetailsDTO>>();
                    }
                    else
                    {
                        var errorResponse = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                        switch (errorResponse.ErrorType)
                        {
                            case "BooksByGenreNotFound":
                                globalError.Text = "No books found for this genre!";
                                break;
                        }

                        return null;
                    }
                }
            }
            catch (HttpRequestException ex)
            {

                globalError.Text = "Error Occured!";
                Console.WriteLine($"HTTP Request Exception: {ex.Message}");
                return null;
            }
            catch (Exception)
            {
                globalError.Text = "Internal Connection Error!";
                return null;
            }
        }

        public async Task<int> GetBookRemainingQuantity(int bookid)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Book/GetBookRemainingQuantity/" + bookid);

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<int>();
                    }
                    else
                    {
                        return -1;
                    }
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
