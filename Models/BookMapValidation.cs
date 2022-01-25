using Flunt.Notifications;
using Flunt.Validations;

namespace APIDemo.Models
{
    public class BookMapValidation :Notifiable<Notification>
    {
         public int BookID { get; set; }
        public string Title { get; set; }

        public int Year { get; set; }
        public long ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public short Price { get; set; }
        public int AuthorID { get; set; }
        public Book MapTo()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNull(Title, "Informe o título da tarefa")
                .IsGreaterThan(Title, 5, "O título deve conter mais de 5 caracteres"));

            return new Book(BookID ,Title , Year , ISBN , PublishedDate , Price , AuthorID);
        }
    }
}