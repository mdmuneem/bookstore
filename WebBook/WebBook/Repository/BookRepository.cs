using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBook.Model;

namespace WebBook.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string bookName,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(bookName) || x.Author.Contains(authorName)).ToList();
        }
        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC Complete Refe",Author="Nitish"},
                new BookModel(){Id=2,Title="Dot Net Complete Ref",Author="muneem"},
                new BookModel(){Id=3,Title="Java Complete Ref",Author="Jyothi Basu"},
                new BookModel(){Id=4,Title="Excel VBA",Author="Luthor King"},
                new BookModel(){Id=5,Title="Macros Reading",Author="Md Muneem"}
            };
        }
    }
}
