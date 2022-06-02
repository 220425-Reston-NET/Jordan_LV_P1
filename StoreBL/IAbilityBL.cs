using StoreModel;

namespace StoreBL
{
    public interface IAbilityBL
    {
        /// <summary>
        /// Will give you all the eztra info of Store Item from the DB
        /// </summary>
        /// <returns>Returns a list of ability objects</returns>
        List<StoreAbility> GetAllAbility();

        /// <summary>
        /// Will find an ability in the DB based on the brand name
        /// </summary>
        /// <param name="p_ItemInfo">The name parameter used to find the ability</param>
        /// <returns>Returns an ability object that it found or a null if no Store Item was found</returns>
        List<StoreAbility>SearchAbilityByName(string p_ItemInfo);
    }
}