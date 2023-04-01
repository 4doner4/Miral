namespace ForPractice.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string NameBook { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Chapter> Chapters { get; set; }

        public Book()
        {
            Chapters = new List<Chapter>();
        }
    }
}
