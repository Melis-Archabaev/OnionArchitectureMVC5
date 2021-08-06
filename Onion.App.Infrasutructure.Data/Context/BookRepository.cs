using OnionApp.Domain.Core.Entities;
using OnionApp.Domain.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.App.Infrasutructure.Data.Context
{
    public class BookRepository : IBookRepository
    {
        private OrderContext db;
        public BookRepository()
        {
            this.db = new OrderContext();
        }
        public void Create(Book book)
        {
            db.Books.Add(book);
        }

        public void Delete(int id)
        {
            Book book = db.Books.Find(id);
            if (book != null)
                db.Books.Remove(book);
        }
        public Book GetBook(int id)
        {
            return db.Books.Find(id);
        }

        public IEnumerable<Book> GetBookList()
        {
            return db.Books.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
