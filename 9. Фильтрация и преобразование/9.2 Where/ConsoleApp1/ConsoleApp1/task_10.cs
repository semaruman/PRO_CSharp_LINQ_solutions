class User
{
    //Имя пользователя
    public string Name { get; set; }

    //Номер школы
    public int SchoolNumber { get; set; }

    //Флаг указывающий отпралял ли пользователь сообщения или лайки
    public bool LikeOrMessages { get; set; }

    static IEnumerable<User> GetUser(IEnumerable<User> users)
    {
        //реализовать логику
        return users.Where(user => (user.SchoolNumber == 30 || user.SchoolNumber == 108) && user.LikeOrMessages);
    }
}