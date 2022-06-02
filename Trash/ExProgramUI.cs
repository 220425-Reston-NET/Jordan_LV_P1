// // See https://aka.ms/new-console-template for more information
// // using StoreUI;


// // Console.WriteLine("Hello, World!");

// // //Creating an object
// // Pokemon pokeObj = new Pokemon();
// // pokeObj.PokeID = 100;
// // Console.WriteLine(pokeObj.PokeID);
// // pokeObj.PokeID = -10;
// // Console.WriteLine(pokeObj.PokeID);

// // //Adding abilities to obj
// // Ability abi1 = new Ability();
// // abi1.Name = "Tackle";
// // Ability abi2 = new Ability();
// // abi2.Name = "Screech";

// // pokeObj.Abilities.Add(abi1);
// // pokeObj.Abilities.Add(abi2);

// // //Display everything that pokemon obj currently has in its abilities
// // foreach (Ability item in pokeObj.Abilities)
// // {
// //     Console.WriteLine(item.Name);
// // }


// // Console.Clear();

// // //Creating MainMenu obj
// // MainMenu menu = new MainMenu();
// // bool repeat = true;
// global using Serilog;
// using StoreBL;
// using StoreDL;
// using StoreUI;
 
// //Initializing my logger
// Log.Logger = new LoggerConfiguration() //LoggerConfiguration used to configure your logger and create it
//     .WriteTo.File("./logs/user.txt") //Configuring the logger to save information to a file called user.txt inside of logs folder
//     .CreateLogger(); //A method to create the logger

// //Creating MainMenu obj
// // Another form of polymorphism called Variance
// // Variance - that is letting a reference variable have multiple forms/objects hold by having it define as an interface 
// IMenu menu = new MainMenu();

// bool repeat = true;
// while (repeat)
// {
//     Console.Clear();
//     menu.Display();
//     string ans = menu.YourChoice();

//     if (ans == "MainMenu")
//     {

//     }
//     else if (ans == "AddStoreItem")
//     {

//     }
//     else if (ans == "Exit")
//     {
//         repeat = false;
//     }
// }

