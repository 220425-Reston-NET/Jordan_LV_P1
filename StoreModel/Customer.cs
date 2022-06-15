using System.ComponentModel.DataAnnotations;

namespace StoreModel
{



       public class Customer
{
    

           private string _FirstName;
        //This is a property
       
        public string FirstName
        {
            get { return _FirstName; }
            set 
            { 
                if (value.Length >0)
                {
                    _FirstName = value;
                }
                else
                {
                   
                    Console.WriteLine("Invalid Input! )");
                }
            }
        }

       
        private string _LastName;
          public string LastName
        {
            get { return _LastName; }

            set 
            { 
                if (value.Length >0 )
                {
                    _LastName = value;
                }
                else
                {
                    
                    Console.WriteLine("Invalid Input! ");
                }
            }
        }
 private int _PhoneNumber;
 public int PhoneNumber
        {
            get { return _PhoneNumber; }
            set 
            { 
                if (value >0 )
                {
                    _PhoneNumber = value;
                }
                else
                {
                    
                }
            }
        }


      private string _Address;
          public string Address
        {
            get { return _Address; }

            set 
            { 
                if (value.Length >0 )
                {
                    _Address = value;
                }
                else
                {
                    
                    Console.WriteLine("Invalid Input! ");
                }
            }
        }
   
   
      private string _Email;
          public string Email
        {
            get { return _Email; }

            set 
            { 
                if (value.Length >0 )
                {
                    _Email = value;
                }
                else
                {
                    
                    Console.WriteLine("Invalid Input! ");
                }
            }
        }

    

        // public List <Customer> CustomerInfo { get; set; }
    

        

       
        public Customer()
        {
            PhoneNumber = 832489 ;
            FirstName = "Jordan";
            LastName = "Lopez";
           Address = "8591 W first Street Kansas City";
           Email = "jlopeZ@hotmail.com";
            
        }

//Override the tostring method to display object information
        //If you want to display the object information in a string format in multiple places
        //You can access this method by just doing (objectName).ToString()
        public override string ToString()
        {
            return $"===First Name===  {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nAddress: {Address}\nPhoneNumber: {PhoneNumber}\n==============";
        }







    }
}