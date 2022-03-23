using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBook.Model;
using WebBook.Repository;

namespace WebBook.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository=null;
      public BookController()
        {
            _bookRepository = new BookRepository();
        }

       public ViewResult GetAllBooks()
        {
            var data=_bookRepository.GetAllBooks();
            return View();
        }
       public BookModel GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }
       public List<BookModel> searchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
