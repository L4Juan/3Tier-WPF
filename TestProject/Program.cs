using BusinessLayer;
namespace TestProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string id = "0";
        string pwd = "pass";
        BusinessLayer.HandlerBusiness businessHandler = new BusinessLayer.HandlerBusiness(id, pwd);

    }
}
