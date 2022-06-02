// See https://aka.ms/new-console-template for more information
global using Serilog;
using Microsoft.Extensions.Configuration;
using StoreBL;
using StoreDL;
using StoreUI;

//Initializing my logger
Log.Logger = new LoggerConfiguration() //LoggerConfiguration used to configure your logger and create it
    .WriteTo.File("./logs/user.txt") //Configuring the logger to save information to a file called user.txt inside of logs folder
    .CreateLogger(); //A method to create the logger

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();


//Creating MainMenu obj
// Another form of polymorphism called Variance
// Variance - that is letting a reference variable have multiple forms/objects hold by having it define as an interface 
IMenu menu = new MainMenu();

 
bool repeat = true;

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.YourChoice();
    
    if (ans == "Store Menu")
    {
        Log.Information("User going to Store Menu");
        menu = new MainMenu();
    }
    else if (ans == "Register With Us")
    {
        // Need to add customer inside of the parameter
        Log.Information("User going to Register With Us");
        menu = new CustomerUI(new CustomerBL(new SQLCustomerRepo(configuration.GetConnectionString("StoreProgramSettings"))));
    }
    else if (ans == "Search Store Item")
    {
        Log.Information("user going to Search Item menu");
        menu = new SearchStoreItem(new StoreItemBL(new SQLStoreRepository(configuration.GetConnectionString("StoreProgramSettings"))));
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }

    
    // else if (ans == "Search Store Inventory")
    // {
    //     Log.Information("User is goint to view ability");
    //     menu = new StoreAbility(new StoreAbilityJoinBL(new SQLStoreAbilityJoinRepo())(configuration.GetConnectionString("StoreProgramSettings"))));
    // }


}