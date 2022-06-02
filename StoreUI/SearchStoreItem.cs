using StoreBL;
using StoreModel;

public class SearchStoreItem : IMenu
{
    public static StoreItem foundedStoreItem;

    //===========Dependency Injection===========
    private IStoreItemBL _storeBL;
    public SearchStoreItem(IStoreItemBL p_storeBL)
    {
        _storeBL = p_storeBL;
    }

    //==========================================
    public void Display()
    {
        Console.WriteLine("How would you like to search your Store Item?");
        Console.WriteLine("[2] - Search by Brand Name of Shoe");
        Console.WriteLine("[1] - Search by Shoe Size");
        Console.WriteLine("[0] - Main Menu");
    }

    public string YourChoice()
    {
        
            
        string userInput = Console.ReadLine();

        // if (userInput == "2")
        // {
        //     //Search logic by Store Item Id
        //     return "Search by Shoe Model";
        // }
         if (userInput == "2")
        {
            //Search logic by store item brand
            Console.WriteLine("Search by Brand Name of Shoe or Shoe Model ");
            string Brand = Console.ReadLine();
            
             foundedStoreItem = _storeBL.SearchStoreItemByName(Brand);

           
            if (foundedStoreItem == null)
            {
                Console.WriteLine("Store Item was not found!");
                return "Search Store Item";
            }
            else
            {
                Console.WriteLine(foundedStoreItem.ToString());

                
                Console.WriteLine("Do you want to add Information to Store Item? (Y - Yes, N - No)");
                string addItemChoice = Console.ReadLine();
                if (addItemChoice == "Y")
                {
                    return "Select Information";
                }
                else
                {
                    return "Search by Brand Name of Shoe";
                }
            } 
            }
       
       
        else if (userInput == "1")
        {
            //Search logic by type
            return " Search By Shoe Size";
        }
        else if (userInput == "0")
        {
            //Exit
            return "Main Menu";
        }
        else
        {
            return "Search Store Item";
        }
    }
}