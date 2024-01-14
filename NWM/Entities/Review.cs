namespace NWM.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime DateAdded { get; set; }

        public Book? Book { get; set; }
    }
}
