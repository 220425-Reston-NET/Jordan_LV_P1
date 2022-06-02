using System.Text.Json;
using StoreModel;

namespace StoreDL
{
    //This class is responsible for storing and reading our data
    public class StoreItemRepository : IRepository<StoreItem>
    {
        private string _filepath = "../StoreDL/Data/StoreItem.json";

        //Purpose of this method is to add a Item to our data
        public void Add(StoreItem p_storeItem)
        {
            List<StoreItem> listOfStoreItem = GetAll();
            listOfStoreItem.Add(p_storeItem);

            string jsonString = JsonSerializer.Serialize(listOfStoreItem, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }

        public List<StoreItem> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<StoreItem> listOfStoreItem = JsonSerializer.Deserialize<List<StoreItem>>(jsonString);

            return listOfStoreItem;
        }

        public void Update(StoreItem p_resource)
        {
            // Current information from the database
            List<StoreItem> listOfStoreItem = GetAll();

            //Finds the matching pokemon object in the database
            foreach (StoreItem storeObj in listOfStoreItem)
            {
                //Condition to find the same pokemon
                if (storeObj.Brand == p_resource.Brand)
                {
                    //Saves this information to the list collection
                    storeObj.Brand = p_resource.Brand;
                }
            }

            //Saves this information to the database
            string jsonString = JsonSerializer.Serialize(listOfStoreItem, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);   
        }
    }

}