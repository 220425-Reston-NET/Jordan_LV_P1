using StoreDL;
using StoreModel;

namespace StoreBL
{


    public class StoreItemBL : IStoreItemBL
    {
        //================== Dependency Injection ====================
        private IRepository<StoreItem> _storeRepo;

            public StoreItemBL(IRepository<StoreItem> p_storeRepo)
        {
            _storeRepo = p_storeRepo;
        }

        public void AddAbilityToStoreItem(StoreItem p_storeItem)
        {
            //Logic to update StoreItem
            _storeRepo.Update(p_storeItem);

        }



        //============================================================

        public void AddStoreItem(StoreItem p_store)
        {
    
    //  List<StoreItem> currentListOfStore = _storeRepo.GetAll();
            Random rand = new Random();
            p_store.Size = rand.Next(50);

            //Checks if that store Item name already exists
            StoreItem foundedStoreItem = SearchStoreItemByName(p_store.Brand);
            if (foundedStoreItem == null)
            {
                _storeRepo.Add(p_store);
            }
            else
            {
                throw new Exception(" Brand already exist");
            }
            
            
        }

   
       public List<StoreItem> GetAllStoreItems()
       {
           return _storeRepo.GetAll();
       }

       public StoreItem SearchStoreItemByName(string p_itemBrand)
        {
            // List<StoreItem> currentListOfStore = _storeRepo.GetAll();

            // foreach (StoreItem storeObj in currentListOfStore)
            // {
            //     //Condition to check that the name is similar
            //     if (storeObj.Brand == p_itemBrand)
            //     {
            //         return storeObj;
            //     }
            // }
            
            return _storeRepo.GetAll().First(StoreItem => StoreItem.Brand == p_itemBrand);
            
        }

       public StoreItem SearchStoreItemByModel(string p_itemModel)
        {
            return _storeRepo.GetAll().First(StoreItem => StoreItem.Model == p_itemModel);
        }

        public List<StoreItem> GetAllStoreItem()
        {
            throw new NotImplementedException();
        }

        public StoreItem SearchStoreItemById(int p_storeitemid)
        {
            throw new NotImplementedException();
        }
    }
}

 