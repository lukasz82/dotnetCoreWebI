using System.Collections.Generic;
namespace dotnetCoreMVC.Models
{
    public class ReturnList
    {
        public List<Mails> emailList {set; get;}
        public List<Person> personList {set; get;}
        public List<Author> authors {set; get;}
        public List<Book> books {set; get;}
        public List<BooksAndAuthors> booksAndAuthors{set;get;}
    }
}