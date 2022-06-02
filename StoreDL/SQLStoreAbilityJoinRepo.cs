using Microsoft.Data.SqlClient;
using StoreModel;

namespace StoreDL
{
    public class SQLStoreAbilityJoinRepo : IRepository<StoreAbilityJoin>
    {
        //=================== Dependency Injection ==========================
        private string _connectionString;

        public SQLStoreAbilityJoinRepo()
        {
        }

        public SQLStoreAbilityJoinRepo(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }

        //=====================Dependency Injection ========================
 
        public void Add(AbilityRepository p_resource)
        {
            throw new NotImplementedException();
        }

        public void Add(StoreAbilityJoin p_resource)
        {
            throw new NotImplementedException();
        }

        public List<StoreAbilityJoin> GetAll()
        {
            throw new NotImplementedException();
        }
       

        public void Update(StoreAbilityJoin p_resource)
        {
            string SQLquery ="Select * StoreItemAbilities, set inner join Color = @Color,set inner join Price = @Price, set inner join Quantity = @Quantity,set inner join Material = @Material";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLquery, con);
                
                command.Parameters.AddWithValue("@Color", p_resource.Color);
                command.Parameters.AddWithValue("@Price", p_resource.Price);
                command.Parameters.AddWithValue("@Quantity", p_resource.Quantity);
                command.Parameters.AddWithValue("@Material", p_resource.Material);

                command.ExecuteNonQuery();
            }
        }

       
    }

       
}
