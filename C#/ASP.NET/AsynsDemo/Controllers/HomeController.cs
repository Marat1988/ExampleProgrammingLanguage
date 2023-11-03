using AsynsDemo.Domain;
using AsynsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsynsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly BooksRepository bookRepository;

        public HomeController(BooksRepository newBooksRepository)
        {
            this.bookRepository = newBooksRepository;
        }

        public async Task<IActionResult> GetBooksAsync()
        {
            int idBefore = Thread.CurrentThread.ManagedThreadId;
            IEnumerable<Book> model = await bookRepository.GetBooksAsync();
            int idAfter = Thread.CurrentThread.ManagedThreadId;
            return View("Index", model);
        }

        public async Task<string> GetHttpRequestData()
        {
            HttpClient httpClient = HttpClientFactory.Create();
            string data = await httpClient.GetStringAsync("https://google.com/");
            return data;
        }
    }
}
