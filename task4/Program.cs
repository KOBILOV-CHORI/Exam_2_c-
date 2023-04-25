var user1 = new User("Chori", "Kobilov", "chori_007", 12093487);
var user2 = new User("Bakhtovar", "Rizozoda", "bakhtik", 09099009);
var user3 = new User("user3", "user3", "user_3", 09099009);
var user4 = new User("user4", "user4", "user_4", 90900990);
var user5 = new User("user5", "user5", "user_5", 90099009);
List<User> users = new List<User>();
users.Add(user1);
users.Add(user2);
users.Add(user3);
users.Add(user4);
users.Add(user5);

bool no = true;
bool yes = false;
var User_true = new User();
while (no)
{
    System.Console.WriteLine();
    System.Console.Write("Enter your user name: ");
    var user = Console.ReadLine();
    System.Console.Write("Enter your password: ");
    var pass = Convert.ToInt32(Console.ReadLine());


    var login = new User(user, pass);
    foreach (User _user in users)
    {
        if ((_user.UserName == user) && (_user.Password == pass))
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Login successful! Welcome mr.{_user.FirstName}, {_user.LastName}!");
            System.Console.WriteLine();
            no = false;
            yes = true;
            User_true = _user;
        }
    }
    if (no) System.Console.WriteLine("Login Failed");
}
if (yes)
{
    System.Console.WriteLine("If you want get info of your account enter 'info'");
    System.Console.WriteLine("If you want get info of your account login enter 'login'");
    var enter = Console.ReadLine();
    switch (enter)
    {
        case "info":
            User_true.GetInfo();
            break;
        case "login":
            User_true.Login();
            break;
        default:
            System.Console.WriteLine("OK");
            break;
    }
}


public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? UserName { get; set; }
    public int Password { get; set; }
    public User(string? firstname, string lastname, string? username, int password)
    {
        this.FirstName = firstname;
        this.LastName = lastname;
        this.UserName = username;
        this.Password = password;
    }
    public User(string? username, int password)
    {
        this.UserName = username;
        this.Password = password;
    }
    public User()
    {

    }
    public void GetInfo()
    {
        System.Console.WriteLine("First Name: " + FirstName);
        System.Console.WriteLine("Last Name: " + LastName);
    }
    public void Login()
    {
        System.Console.WriteLine("User Name: " + UserName);
        System.Console.WriteLine("Password: " + Password);
    }
}