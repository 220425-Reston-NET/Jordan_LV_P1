using StoreModel;
 
namespace StoreBL
{
    /// <summary>
    /// Business Layer is responsible for further validation or process of data obtained from the database or the user
    /// What kind of process? That all depends on the type of functionality you will be doing
    /// </summary>
    public interface IStoreItemBL
    {
        
        /// <summary>
        /// Add Store Item to the database
        /// </summary>
        /// <param name="p_store">This is the Store object that will be added to the DB</param>
        /// <returns>Gives back the Store Item that gets added to the DB</returns>
        void AddStoreItem(StoreItem p_store);
        // List<global::StoreUI.StoreAbility> GetAllAbility();

        /// <summary>
        /// This will search for a Store Item in the DB using their name
        /// </summary>
        /// <param name="p_ItemBrand">Name of the Store item used to search</param>
        /// <returns>Multiple Store Items if they have matching name</returns>
        StoreItem SearchStoreItemByName(string p_itemBrand);
        
        // List<StoreItem> SearchStoreItemIdById(int p_StoreItemId);
        void AddAbilityToStoreItem(StoreItem p_storeitem);

        
        /// <summary>
        /// Will give current pokemon in the DB
        /// </summary>
        /// <returns>List object that holds Store Items</returns>
        List<StoreItem> GetAllStoreItem();

        /// <summary>
        /// Will search a StoreItem by Id
        /// </summary>
        /// <param name="p_id">The pokeID</param>
        /// <returns>Pokemon object it found or null if pokemon not found</returns>
        StoreItem SearchStoreItemById(int p_storeitemid);
    }
}