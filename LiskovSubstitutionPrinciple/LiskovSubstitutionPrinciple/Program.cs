using System.Net;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        IAdmin admin = new Admin("admin");
        IEmployee Employee = new Employee("member");
        DoSomething(admin);
        DoSomething(Employee);
    }

    public static void DoSomething(IUser user)
    {
        user.LogIn();
        user.LogOut();

        if (user is IAdmin admin)
        {
            admin.AccessAdmin();
        }
    }
}

    public interface IUser
    {
        void LogIn();
        void LogOut();
    }

    public interface IAdmin : IUser
    {
        void AccessAdmin();
    }

    public interface IEmployee : IUser
    {
    //TODO - add employee specific methods
}

public class User : IUser
    {
        private string _name;
        public User(string name)
        {
            _name = name;
        }
        public void LogIn()
        {
            Console.WriteLine($"User {_name} Logged In");
        }
        public void LogOut()
        {
            Console.WriteLine($"User {_name} Logged Out");
        }

    }


public class Admin : User, IAdmin
{
    public Admin(string name) : base(name)
    {
    }
    public void AccessAdmin()
    {
        Console.WriteLine("Admin Access Granted");
    }
}

public class Employee : User, IEmployee
{
    public Employee(string name) : base(name)
    {
    }
}

