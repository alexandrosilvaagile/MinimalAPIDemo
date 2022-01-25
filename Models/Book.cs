

namespace APIDemo.Models
{
    public class Book
    {
        public Book(int bookID, string title, int year, long iSBN, DateTime publishedDate, short price, int authorID)
        {
            BookID = bookID;
            Title = title;
            Year = year;
            ISBN = iSBN;
            PublishedDate = publishedDate;
            Price = price;
            AuthorID = authorID;
        }

        [Key]
        public int BookID { get; set; }
        public string Title { get; set; }

        public int Year { get; set; }
        public long ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public short Price { get; set; }

        public int AuthorID { get; set; }
    }
    class BooksDB : DbContext
    {
        public BooksDB(DbContextOptions<BooksDB> options) : base(options) { }
         protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");
        public DbSet<Book> Books => Set<Book>();
    }
}
