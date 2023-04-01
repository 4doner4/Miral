namespace ForPractice.Model
{
    public class Chapter
    {
        public int Id { get; set; }
        public string ChapterName { get; set; }
        public string ChapterText { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
