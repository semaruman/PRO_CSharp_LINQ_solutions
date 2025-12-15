namespace task4
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        static IEnumerable<User> GetAdulthood(IEnumerable<User> users)
        {
            // реализовать логику
            return users.Where(user => user.Age >= 18);
        }
    }
}