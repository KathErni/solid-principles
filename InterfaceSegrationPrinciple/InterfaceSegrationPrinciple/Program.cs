public class Program
{
    public static void Main()
    {
        IEmployee employee = new Employee();
        employee.TimeIn();
        employee.Work();
        IManager manager = new Manager();
        manager.TimeIn();
        manager.Manage();
        IAdmin admin = new Admin();
        admin.TimeIn();
        admin.Work();
        admin.DeleteUser();
    }
}

public interface IEmployee
{
    public void TimeIn();
    public void Work();

}

public interface IManager
{
    public void TimeIn();
    public void Manage();
}

public interface IAdmin
{
    public void TimeIn();
    public void Work();
    public void DeleteUser();
}
public class Manager : IManager
{
    public void TimeIn()
    {
        Console.WriteLine("Manager timed in");
    }

    public void Manage()
    {
        Console.WriteLine("Manager is managing");
    }
}
public class Employee : IEmployee
{
    public void TimeIn()
    {
        Console.WriteLine("Employee timed in");
    }

    public void Work()
    {
        Console.WriteLine("Employee is working");
    }
}
public class Admin : IAdmin
{
    public void TimeIn()
    {
        Console.WriteLine("Admin timed in");
    }

    public void Work()
    {
        Console.WriteLine("Admin is working");
    }

    public void DeleteUser()
    {
        Console.WriteLine("Admin deleted a user");        
    }
}