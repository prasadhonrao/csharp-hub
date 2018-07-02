namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User()
                        {
                            Id = 1,
                            Name = "Prasad Honrao",
                            Age = 30
                        };
        }
    }

    public partial class User
    {
        public int Id { get; set; }
    }
}
