using System.Text.Json;
using StoreModel;

namespace StoreDL
{
    //This class is responsible for storing and reading our data
    public class CustomerRepository : IRepository<Customer>
    {
        private string _filepath = "../StoreDL/Data/CustomerInfo.json";

        //Purpose of this method is to add a pokemon to our data
        public void Add(Customer p_customer)
        {
            List<Customer> listOfCustomer = GetAll();
            listOfCustomer.Add(p_customer);

            string jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }

        public List<Customer> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Customer> listOfCustomer = JsonSerializer.Deserialize<List<Customer>>(jsonString);

            return listOfCustomer;
        }

        public void Update(Customer p_resource)
        {
            // Current information from the database
            List<Customer> listOfCustomer = GetAll();

            //Finds the matching pokemon object in the database
            foreach (Customer customerObj in listOfCustomer)
            {
                //Condition to find the same customer
                if (customerObj.FirstName == p_resource.FirstName)
            
                {
                    //Saves this information to the list collection
                    customerObj.FirstName = p_resource.FirstName;
                }
            }

            //Saves this information to the database
            string jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);   
        }
    }

}