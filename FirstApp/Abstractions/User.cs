namespace FirstApp.Abstractions
{
    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Login { get; set; }

        public string HashPassword { get; set; }

        public string Email { get; set; }

        public Roles Role { get; set; }
    }
}
