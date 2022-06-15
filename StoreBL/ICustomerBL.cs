using StoreModel;

namespace StoreBL
{

 /// <summary>
    /// Business Layer is responsible for further validation or process of data obtained from the database or the user
    /// What kind of process? That all depends on the type of functionality you will be doing
    /// </summary>
    public interface ICustomerBL
    {

        /// <summary>
        /// Add Customer to the database
        /// </summary>
        /// <param name="p_customer">This is the pokemon object that will be added to the DB</param>
        /// <returns>Gives back the customer name that gets added to the DB</returns>
        void AddCustomer(Customer p_customer);

        /// <summary>
        /// This will search for a customer in the DB using their name
        /// </summary>
        /// <param name="p_customerName">Name of the customer used to search</param>
        /// <returns>Multiple customer name if they have matching name</returns>
        Customer SearchCustomerByName(string p_customerFirstName, string p_customerLastName);

        List<Customer> SearchCustomerByName(string p_customerFirstName);
        Task<List<Customer>> GetAllCustomerInfoAsync();
    }
}