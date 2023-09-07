using Library_Windows_Application.DTOs;
using Library_Windows_Application.Models;
using System;
using System.Net.Http.Json;

namespace Library_Windows_Application.Assemblers
{
    public class BorrowAssembler
    {
        public async Task<IEnumerable<BorrowDetailsDTO>?> GetAllBorrowedBooks(int userid)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Borrow/GetBorrowedBooksByUser/" + userid );

                    if (response.IsSuccessStatusCode)
                    {
                        var books = await response.Content.ReadFromJsonAsync<IEnumerable<BorrowDetailsDTO>>();
                        return books;
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

        public async Task<IEnumerable<BorrowDetailsDTO>?> GetReturnedBorrowedBooks(int membershipID)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Borrow/GetReturnedBooks/" + membershipID);

                    if (response.IsSuccessStatusCode)
                    {
                        var books = await response.Content.ReadFromJsonAsync<IEnumerable<BorrowDetailsDTO>>();
                        return books;
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

        public async Task<IEnumerable<BorrowDetailsDTO>?> GetUnReturnedBorrowedBooks(int membershipID)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Borrow/GetUnReturnedBooks/" + membershipID);

                    if (response.IsSuccessStatusCode)
                    {
                        var books = await response.Content.ReadFromJsonAsync<IEnumerable<BorrowDetailsDTO>>();
                        return books;
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
        public async Task<IEnumerable<Borrow?>> GetBookBorrowRecords(int bookid,int userid)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Borrow/GetBookBorrowRecords/" + bookid + "/" + userid);

                    if (response.IsSuccessStatusCode)
                    {
                        var borrowRecs = await response.Content.ReadFromJsonAsync<IEnumerable<Borrow>>();
                        return borrowRecs;
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

        public async Task<Borrow?> GetBorrowRecordByMembership(int bookid, int membershipID)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync("https://localhost:5000/api/Borrow/GetBorrowRecordByMembership/" + bookid + "/" + membershipID);

                    if (response.IsSuccessStatusCode)
                    {
                        var borrowRecs = await response.Content.ReadFromJsonAsync<Borrow>();
                        return borrowRecs;
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

        public async Task<bool> ReturnBorrowedBook(BorrowDTO borrowDTO)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PutAsJsonAsync("https://localhost:5000/api/Borrow/ReturnBorrowedBook", borrowDTO );

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
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> BorrowBook(BorrowDTO borrowDTO)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PostAsJsonAsync("https://localhost:5000/api/Borrow/BorrowBook", borrowDTO);

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
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBorrowBookRecord(BorrowDTO borrowDTO)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.PutAsJsonAsync("https://localhost:5000/api/Borrow/UpdateBorrowBookRecord", borrowDTO);

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
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
