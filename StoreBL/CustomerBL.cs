using StoreDL;
using StoreModel;

namespace StoreBL
{
   
    public class CustomerBL : ICustomerBL
    {
      
      
      private IRepository<Customer> _customerRepo;
        public CustomerBL(IRepository<Customer> p_customerRepo)
        {
            _customerRepo = p_customerRepo;

        }
       
        //============================================================

       public void AddCustomer(Customer p_customer)
        {
         
          Customer foundedcustomer = SearchCustomerByName(p_customer.FirstName,p_customer.LastName);
            if (foundedcustomer == null)
            {
                _customerRepo.Add(p_customer);
            }
            else
            {
                throw new Exception("customer name already exist");
            }
        }

       public  Customer SearchCustomerByName(string p_customerName, string p_customerLastName)
        {
            List<Customer> currentListOfCustomerName = _customerRepo.GetAll();

            foreach (Customer customerObj in currentListOfCustomerName)
            {
                //Condition to check that the name is similar
                if (customerObj.FirstName == p_customerName && customerObj.LastName == p_customerLastName)

                
                {
                    return customerObj;
                }
            }

            //Will return null or no value if no name was found
            return null;

        }

        public List<Customer> SearchCustomerByName(string p_customerName)
        {
            throw new NotImplementedException();
        }
    }

    }