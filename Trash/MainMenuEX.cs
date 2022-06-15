// // namespace StoreUI;

// // public class MainMenu
// // {
// // public void Display()
// // {
// // Console.WriteLine("Welcome To Our Store GULF COAST GEAR.");

// //          string goman = "true";
// //         while (goman == "true")
// //         {
// //             // Create a string variable and get user input from the keyboard and store it in the variable
// //             Console.Write("Whats your name? "); string userName = Console.ReadLine();
// //             Console.Write("Address: "); string userAddress = Console.ReadLine();
// //             Console.Write("City: "); string userCity = Console.ReadLine();
// //             Console.Write("State: "); string userState = Console.ReadLine();
// //             Console.Write("Zip Code: "); string userZip=  Console.ReadLine();
            
// //         }


        
// // Console.Clear();
// // Console.WriteLine("Welcome To Our GulF Coast Gear Store");
// // bool repeat = true;
// // while (repeat) 

// // {
// //   Console.WriteLine("Thank you on joining our customer list" );
// //   Console.WriteLine("As a customer wuold recieve special offers and discount via email" );
// //   Console.WriteLine("1. Mens and Womens Accessories" );
// //   Console.WriteLine("2. Womans Apparel" );
// //   Console.WriteLine("3. Womans Handbags " );
// //   Console.WriteLine("4. Womans Tops" );
// //   Console.WriteLine("5. Women Shoes" );
// //   Console.WriteLine("6. Mens Shoes" );
// //   Console.WriteLine("7. Mens T-shirts" );
// //   Console.WriteLine("8. Mens Jeans" );
// //   Console.WriteLine("9. Mens Apparel" );
// //   Console.WriteLine("10 If you would like to Exit" );
// //   Console.WriteLine("View My Shopping Cart" );
// //   Console.WriteLine("If you would like to Checkout please press 0" );
// // }
// // }

// //     private static string YourChoice
// //     {
// //         get
// //         {
// //             string userInput = Console.ReadLine();

// //             if (userInput == "1")
// //             {
// //                 //Logic add pokemon
// //                 Console.Clear();
// //                 StoreItemID storeobj = new StoreItemID();
// //                 Console.WriteLine("What is the name of the pokemon?");
// //                 storeobj.Name = Console.ReadLine();
// //                 Console.WriteLine("What is the Type of the pokemon?");
// //                 storeobj.Type = Console.ReadLine();
// //                 Console.WriteLine("What is the PokeID?");
// //                 //Since PokeId is a integer and Console.ReadLine() gives a string, we have to convert to int
// //                 storeobj.SetStoreItemID(Convert.ToInt32(Console.ReadLine()));

// //                 object value = Repository.ProgramUI(storeobj);
// //                 return "Add Customer";
// //             }
// //             else if (userInput == "0")
// //             {
// //                 //Logic to exit
// //                 return "Exit";
// //             }
// //             else
// //             {
// //                 Console.WriteLine("Please input a valid response");
// //                 return "MainMenu";
// //             }
// //         }
// //     }

// //     public static object Repository { get; private set; }
// // }

// //     Console.WriteLine("Welcome to GULF COAST GEAR");
// //     Console.WriteLine("What can I do for you");
// //     Console.WriteLine("[1] - Add a new Item");
// //     Console.WriteLine("[0] - Exit");

// // public  string userInput = Console.ReadLine();
// // {
// //     if (userInput == "1")
// //     {
// //         return "AddStoreProgram";
// //     }
// // else if (userInput == "0")
// //     {

// //      return "Exit";

// //     }
// //    else
// //    {
// //         Console.WriteLine("Please input a valid response");
// //          return "MainMenu";
// //     }

// //      }
// //   }  
// // }

  


// using StoreDL;
// using StoreModel;

// namespace ProgramUI
// {
//     public class MainMenu
//     {
//         //This method will display things in your terminal that will show what the user can do
//         public void Display()
//         {
//             Console.WriteLine("Welcome to the Main Menu!");
//             Console.WriteLine("What can I do for you?");
//             Console.WriteLine("[1] - Add a new pokemon");
//             Console.WriteLine("[0] - Exit");
//         }

//         //This method will ask the user what to do
//         public string YourChoice()
//         {
//             string userInput = Console.ReadLine();

//             if (userInput == "1")
//             {
//                 //Logic add pokemon
//                 Console.Clear();
//                 StoreDL itemobj = new StoreDL();
//                 Console.WriteLine("What is the name of the Store Iem?");
//                 itemobj.Name = Console.ReadLine();
//                 Console.WriteLine("What is the Type of the Store Item?");
//                 itemobj.Type = Console.ReadLine();
//                 Console.WriteLine("What is the PokeID?");
//                 //Since PokeId is a integer and Console.ReadLine() gives a string, we have to convert to int
//                 itemobj.StoreItemID = Convert.ToInt32(Console.ReadLine());

//                 Repository.AddStoreItem(itemobj);
//                 return "AddStoreItem";
//             }
//             else if (userInput == "0")
//             {
//                 //Logic to exit
//                 return "Exit";
//             }
//             else
//             {
//                 Console.WriteLine("Please input a valid response");
//                 return "MainMenu";
//             }
//         }
//     }
// }




