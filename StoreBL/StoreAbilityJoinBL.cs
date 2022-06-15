using StoreDL;
using StoreModel;

namespace StoreBL
{
    public class StoreAbilityJoinBL : IStoreAbilityJoinBL
    {
        //========================================
        private IRepository<StoreAbilityJoin> _StoreAbilityRepo;
        public StoreAbilityJoinBL(IRepository<StoreAbilityJoin> p_StoreAbilityRepo)
        {
            _StoreAbilityRepo = p_StoreAbilityRepo;
        }


        //=======================================

        public void ReplenishAbilityStoreItem(int p_Size, int p_Quantity, string p_Color, string p_Material)
        {
            StoreAbilityJoin joinTable = new StoreAbilityJoin();
            joinTable.Size = p_Size;
            joinTable.Quantity = p_Quantity;
            joinTable.Color = p_Color;
            joinTable.Material = p_Material;

            //Logic to check if the StoreItem even exist

            _StoreAbilityRepo.Update(joinTable);
        }

        public void ReplenishAbilityStoreItem(int p_Quantity, int p_Size, int p_StoreItemId)
        {
            throw new NotImplementedException();
        }
    }
}