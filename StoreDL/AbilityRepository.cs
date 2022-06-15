using System.Text.Json;
using StoreModel;

namespace StoreDL
{
    public class AbilityRepository : IRepository<StoreAbility>
    {
        private string _filepath = "../StoreDL/Data/StoreAbility.json";
        public void Add(StoreAbility p_resource)
        {
            throw new NotImplementedException();
        }

        public List<StoreAbility> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<StoreAbility> listOfAbility = JsonSerializer.Deserialize<List<StoreAbility>>(jsonString);

            return listOfAbility;
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(StoreAbility p_resource)
        {
            throw new NotImplementedException();
        }
    }
}