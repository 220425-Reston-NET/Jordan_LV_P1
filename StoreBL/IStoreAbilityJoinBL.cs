namespace StoreBL
{
    public interface IStoreAbilityJoinBL
    {
        /// <summary>
        /// This will replenish the store item ability
        /// </summary>
        /// <param name="p_Size">This is the item size it will replenish</param>
        /// <param name="p_Quantity">This is the item amount it will replenish</param>
        /// <param name="p_Color">This is the store item that it will replenish</param>
        /// <param name="p_Material">This is the store item that has that ability that will replenish</param>
        void ReplenishAbilityPP(int p_Size,int p_Quantity, string p_Color, string p_Material);
    }
}