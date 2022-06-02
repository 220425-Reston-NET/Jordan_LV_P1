//  public class CustomerBL : ICustomerBL
//     {
//     /// <summary>
//     /// Business Layer is responsible for further validation or process of data obtained from the database or the user
//     /// What kind of process? That all depends on the type of functionality you will be doing
//     /// </summary>


    
//         //================== Dependency Injection ====================


//         public void AddAbilityToCustomer(Customer p_customerName);
//             //Logic to update customer
//             _customerRepo.Update(p_customerName);

//         //============================================================

//         public void AddCustomer(CustomerBL p_customerName)
//         {
            
//             //Checks if that customer name already exists
//             StoreItem foundedStoreItem = SearchCustomerByName(p_customerName.Name);
//             if (foundedStoreItem == null)
//             {
//                 _customerRepo.Add(p_customerName);
//             }
//             else
//             {
//                 throw new Exception(" Name already exist");
//             }
//         }

//         public CustomerBL SearchCustomerByName(string _customerName)
//         {
//             List<AddCustomer> currentListOfCustomerName = p_customerName.GetAll();

//             foreach (AddCustomer customerObj in currentListOfName)
//             {
                
//                 if (customerObj.Brand == p_customerName)
//                 {
//                     return customerObj;
//                 }
//             }

//             Will return null or no value if no customerName was found
//             return null;
//         }
//     }
// }