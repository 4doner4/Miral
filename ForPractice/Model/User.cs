namespace ForPractice.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Book> Books {get; set;}

        public User ()
        {
            Books = new List<Book>();
        }
    }
}
