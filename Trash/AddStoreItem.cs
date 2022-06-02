// using StoreBL;
// using StoreModel;
// using StoreDL;
// using Serilog;


// namespace StoreUI
// {


// public class AddStoreItem : IMenu
// {
//     private StoreItem _storeObj = new StoreItem ();

    
//     private IRepository<StoreItem>_storeBL;

   
//     public AddStoreItem(IRepository<StoreItem> p_storeBL)
//     {
//         //Set the field with the parameter
//         _storeBL = p_storeBL;
//     } 

//     //NOTE: Look into your program.cs and fix the red line
//     //===========================================


//     public void Display()
//     {
//         Console.WriteLine("Please enter store item details by following the questions");
//         Console.WriteLine("What is the brand name?");
//         _storeObj.Brand = Console.ReadLine();
//         Console.WriteLine("What is the shoe size?");
//         _storeObj.Size = Console.ReadLine();
//         Console.WriteLine("What is the model?");
//         _storeObj.Model = Console.ReadLine();

//         // try
//         // {
//         //     _storeObj.StoreItem = AddStoreItem.ToInt32(Console.ReadLine());
//         // }
//         // catch (System.Exception)
//         // {
//         //     Log.Warning("User tried to add a negative number!");
//         //     Console.WriteLine(" Shoe Size Cannot be negative!");
//         //     _storeObj.StoreItemId = 1;
//         // }
//         Console.WriteLine("[1] - Add the store item");
//         Console.WriteLine("[0] - Exit");
//     }

//     public string YourChoice()
//     {
//         string userInput = Console.ReadLine();

//         if (userInput == "1")
//         {
//             // Repository.AddStoreItem(storeObj);
//             try
//             {
//                 _storeBL.Add(_storeObj);
                
//             }
//             catch (System.Exception)
//             {
//                 Log.Warning("Item name already exist!");
//                 Log.Information(_storeObj.ToString());
//                 Console.WriteLine("Item name already exist!");
//                 Console.ReadLine();
//             }

//             return "MainMenu";
//         }
//         else if (userInput == "0")
//         {
//             return "Exit";
//         }
//         else
//         {
//             Console.WriteLine("Please enter a correct response");
//             return " Add Store Item";
//         }
//     }

// }

// }