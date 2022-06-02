using StoreModel;

namespace StoreUI
{
    public class MainMenu : IMenu
    {
      

        //This method will display things in your terminal that will show what the user can do
        public void Display()
       { 

        
            Console.WriteLine("Welcome to Gulf Coast Gear Main Menu!");
            Console.WriteLine("How may I assist you Today?");
            Console.WriteLine("[1] - Register With Us");
            Console.WriteLine("[2] - Search Store Item");
            Console.WriteLine("[0] - Exit");
            
        
      
       }
        public string YourChoice()
        
        {
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                Console.WriteLine("Thank You, come again!");
                return "Exit";
            
            }
            
            else if (userInput == "1")
            { 
                return "Register With Us";
            }

         
            else if (userInput == "2")
            {
                return "Search Store Item";
            }
            
            
            {
                Console.WriteLine("Please input a valid response");
                return "MainMenu";
            }

            
         

    
     }

    
    }
}