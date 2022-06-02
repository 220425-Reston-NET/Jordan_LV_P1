using StoreBL;
using StoreDL;
using StoreModel;

namespace StoreUI
{
    public class StoreAbility1 : IMenu

    
    {

        public static StoreAbility founded;
        //====Dependency Injection====
        private IAbilityBL _abilityBL;
        private IStoreItemBL _storeBL;

        public StoreAbility1(SQLStoreAbilityJoinRepo sQLStoreAbilityJoinRepo)
        {
        }

        public StoreAbility1(IAbilityBL p_abilityBL, IStoreItemBL p_storeBL)
        {
            _abilityBL = p_abilityBL;
            _storeBL = p_storeBL;
        }
        //============================
        public void Display()
        {
           Console.WriteLine("Search Inventory?");
           
        }

        public string YourChoice()
        {
            
            string userInput = Console.ReadLine();
            
             List<StoreAbility>founded = _abilityBL.SearchAbilityByName(userInput);
          
            
            // StoreAbility foundedAbility = _abilityBL.SearchAbilityByName(userInput);

            //Validation for userInput
            if (founded != null)
           {
                 foreach (StoreAbility abilityObj in founded)
            {
                Console.WriteLine(abilityObj);
            }
           }  
           
           
               
                // SearchStoreItem.foundedStoreItem.Abilities.Add(founded);
                // _storeBL.AddAbilityToStoreItem(SearchStoreItem.foundedStoreItem);
                // Console.WriteLine("Successfully added ability!");
          
            else
            {
                Console.WriteLine("Invalid Response! Please enter the exact name (case sensitive)");
                Console.ReadLine();
                return "SelectAbility";
            }


            //Logic to save that information permanently (UPDATING)
            Console.ReadLine();
            return "MainMenu";

            
        }
    }
}