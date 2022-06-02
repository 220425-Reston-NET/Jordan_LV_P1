
using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class AbilityBL : IAbilityBL
    {
        //====Dependency Injection====
        private IRepository<StoreAbility> _abilityRepo;
        public AbilityBL(IRepository<StoreAbility> p_abilityRepo)
        {
            _abilityRepo = p_abilityRepo;
        }

        //============================

        public List<StoreAbility> GetAllAbility()
        {
            return _abilityRepo.GetAll();
        }

        public List<StoreAbility> SearchAbilityByName(string p_ItemInfo)
        {
            List<StoreAbility> currentListOfAbility = _abilityRepo.GetAll();

            List<StoreAbility>filteredListOfAbility = new List<StoreAbility>();
            foreach (StoreAbility abilityObj in currentListOfAbility)
            {
                if (abilityObj.Material == p_ItemInfo)
                {

                 filteredListOfAbility.Add(abilityObj);

                }
            }

            //Will return null if no ability was found
            return filteredListOfAbility;
        }
    }
}