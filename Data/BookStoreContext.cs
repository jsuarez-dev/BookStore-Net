using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using BookStore.Areas.Identity.Data;

namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public BookStoreIdentityDbContext User { get; set; } = default!;

        public DbSet<BookStore.Models.Author> Author { get; set; } = default!;
        public DbSet<BookStore.Models.Book> Book { get; set; } = default!;
    }
}
