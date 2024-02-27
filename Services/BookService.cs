using BookApp.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Services
{
    public class Book
    {
        public string Name;
        public string Summary;
        public string Author;
        public string PageQuantity;
    }

    public class BookService: BaseService
    {
        public IQueryable<C27_02_Book_> GetAll()
        {
            return
                this.db.C27_02_Book_;
        }

        public bool AddNewBook(C27_02_Book_ newBook)
        {
            try
            {
                this.db.C27_02_Book_.Add(newBook);
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteBookById(C27_02_Book_ bookToDelete)
        {
            try
            {
                this.db.C27_02_Book_.Remove(bookToDelete);
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
