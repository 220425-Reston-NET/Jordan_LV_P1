using StoreBL;
using StoreModel;


public class CustomerUI : IMenu
{
    private Customer customerObj = new Customer();

    //====== Dependency Injection Pattern =======
    //Add the field of the interface you are trying to add
    private ICustomerBL _customerBL;

    //Create a constructor with a parameter of that interface
    public CustomerUI(ICustomerBL p_customerBL)
    {
        //Set the field with the parameter
        _customerBL = p_customerBL;
    }

    //NOTE: Look into your program.cs and fix the red line
    //===========================================


    public void Display()
    {
        Console.WriteLine("Please let us get to know you by answering the following questions");
        Console.WriteLine("What is the your Name?");
        customerObj.FirstName = Console.ReadLine();
        Console.WriteLine("What is your Address?");
        customerObj.Address = Console.ReadLine();
        Console.WriteLine("What is the Email?");
        customerObj.Email = Console.ReadLine();
        Console.WriteLine("What is your Phone Number?");
        customerObj.PhoneNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("[1] - Add your information");
        Console.WriteLine("[0] - Exit");    


    }

    public string YourChoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
             // Repository.CustomerUI(customerObj);
            // try
            // {
            _customerBL.AddCustomer(customerObj);
            // }
            // catch (System.Exception)
            // {
            //     Log.Warning("customer name already exist!");
            //     Log.Information(customerObj.ToString());
            //     Console.WriteLine("customer name already exist!");
            //     Console.ReadLine();
            // }

            return "MainMenu";
        }
        else if (userInput == "0")
        {
            return "Exit";
        }
        else
        {
            Console.WriteLine("Please enter a correct response");
            return "Exit";
        }
    }
        
}