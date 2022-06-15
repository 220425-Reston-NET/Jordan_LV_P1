using Microsoft.Data.SqlClient;
using StoreModel;

namespace StoreDL
{
    public class SQLCustomerRepo : IRepository<Customer>
    {
        //=================== Dependency Injection ==========================
        private string _connectionString;
        
        public SQLCustomerRepo(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }
        
        //=====================Dependency Injection ========================
        
        public void Add(Customer p_resource)
        {
            //@ inside the string acts as a parameter
            //We will dynamically change the information there at a later point in this code
            string SQLQuery = @"insert into CustomerInfo
                                values (@FirstName,@Address,@Email,@PhoneNumber)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                //We fill in the parameters we added earlier
                //We dynamically change information using AddWithValue and Parameters to avoid the risk of SQL Injection attack
                command.Parameters.AddWithValue("@FirstName", p_resource.FirstName);
                 command.Parameters.AddWithValue("@Email", p_resource.Email);
                command.Parameters.AddWithValue("@PhoneNumber", p_resource.PhoneNumber);
                command.Parameters.AddWithValue("@Address", p_resource.Address);
                
                

                //Execute sql statement that is nonquery meaning it will not give any information back (unlike a select statement)
                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAll()
        {
            string SQLQuery = @"select * from CustomerInfo";
            List<Customer> listOfCustomer = new List<Customer>();

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
                    NewMethod(listOfCustomer, reader);
                }

                return listOfCustomer;
            }

            static void NewMethod(List<Customer> listOfCustomer, SqlDataReader reader)
            {
                listOfCustomer.Add(new Customer()
                {

                    //The new pokemon will hold the properties obtained from a single row in SQL
                    //It is Zero-based index meaning the first column would be a 0

                    FirstName = reader.GetString(1),
                    Email = reader.GetString(3),
                    PhoneNumber = reader.GetInt32(4),
                    Address = reader.GetString(2),
                });
            }
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer p_resource)
        {
            throw new NotImplementedException();
        }
    }
}
