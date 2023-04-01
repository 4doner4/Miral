namespace ForPractice.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public User User { get; set; }
    }
}
