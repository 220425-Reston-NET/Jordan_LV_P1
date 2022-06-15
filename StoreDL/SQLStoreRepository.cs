using Microsoft.Data.SqlClient;
using StoreModel;

namespace StoreDL
{
    public class SQLStoreRepository : IRepository<StoreItem>
    {
        //=================== Dependency Injection ==========================
        private string _connectionString;
        
        public SQLStoreRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }
        
        //=====================Dependency Injection ========================
        
        public void Add(StoreItem p_resource)
        {
            //@ inside the string acts as a parameter
            //We will dynamically change the information there at a later point in this code
            string SQLQuery = @"insert into StoreItem 
                                values (@ItemBrand,@ItemModel,@ItemSize)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                //We fill in the parameters we added earlier
                //We dynamically change information using AddWithValue and Parameters to avoid the risk of SQL Injection attack
                
                command.Parameters.AddWithValue("@ItemBrand", p_resource.Brand);
                command.Parameters.AddWithValue("@ItemSize", p_resource.Size);
                command.Parameters.AddWithValue("@ItemModel", p_resource.Model);
                
                

                //Execute sql statement that is nonquery meaning it will not give any information back (unlike a select statement)
                command.ExecuteNonQuery();
            }
        }

       

        public List<StoreItem> GetAll()
        {
            string SQLQuery = @"select * from StoreItem";
            List<StoreItem> listOfStoreItem = new List<StoreItem>();

            //SqlConnection object is responsible for establishing a connection to your database
            //Hence why we pass out connectionString information when we construct that object
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                //This opens the connection to the database
                con.Open();

                //SqlCommand object is responsible for executing sql statements to a database
                //It needs a string that is a sql statement
                //It needs a Sqlconnection obj that has a connection to a database
                SqlCommand command = new SqlCommand(SQLQuery, con);

                //SqlDataReader object is responsible for reading information from a SQL Server database (Since it gives tables and tables doesn't exist in C# only objects/classes)
                SqlDataReader reader = command.ExecuteReader();
                 
                //Mapping the table format that SQL understands to a List collection that C# understands
                //While loop because we don't know how many rows there will be in this table
                //reader.Read() method goes from row to row
                while (reader.Read())
                {
                    //We are adding a new Pokemon object to our list collection
                    listOfStoreItem.Add(new StoreItem(){
                    
                        //The new pokemon will hold the properties obtained from a single row in SQL
                        //It is Zero-based index meaning the first column would be a 0
                        
                        Brand = reader.GetString(1),
                        Size = reader.GetInt32(3),
                        Model = reader.GetString(2),
                        

                    });
                }

                return listOfStoreItem;
            }

        }

      
    


  private List<StoreAbility> GiveAbilityStoreItem(int p_storeItemId)
        {

         string SQLquery = @"select ab.Color, ab.Price, ab.Quantity, ab.Material, from Shoe
                        inner join store_abilities p on p.StoreItemId = p.StoreItemId
                        inner join Store_ability a on p.StoreItemId = p.storeItemId
                        where p.StoreItemId = @StoreItemId";

            List<StoreAbility> listOfAbility = new List<StoreAbility>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {

                con.Open();

                SqlCommand command = new SqlCommand(SQLquery, con);

                command.Parameters.AddWithValue("@StoreItemId", p_storeItemId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfAbility.Add(new StoreAbility(){
                        Color = reader.GetString(1),
                        Price = reader.GetInt32(2),
                        Quantity = reader.GetInt32(3),
                        Material = reader.GetString(4),
                        
                    });
                }
            

            return listOfAbility;
            }
        }
        public void Update(StoreItem p_resource)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
    
  

      