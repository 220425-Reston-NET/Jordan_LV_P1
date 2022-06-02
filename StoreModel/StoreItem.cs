

using System.ComponentModel.DataAnnotations;

namespace StoreModel
{
    public class StoreItem
    {
        //This is a field
        private string _ItemBrand;
        //This is a property
       
        public string ItemBrand
        {
            get { return _ItemBrand; }
            set 
            { 
                if (value.Length > 0)
                {
                    _ItemBrand = value;
                }
                else
                {
                   
                    Console.WriteLine("Invalid Input! )");
                }
            }
        }

       
        private string _ItemModel;

          public string ItemModel
        {
            get { return _ItemModel; }
            set 
            { 
                if (value.Length >0 )
                {
                    _ItemModel = value;
                }
                else
                {
                    
                    Console.WriteLine("Even Numbers Only! )");
                }
            }
        }

    private int _ItemSize;
        public int ItemSize
        {
            get { return _ItemSize; }
            set 
            { 
                if (value >0 )
                {
                    _ItemSize = value;
                }
                else
                {
                    
                }
            }
        }


        public string Model { get; set; }
         public string Brand { get; set; }
         public int Size { get; set; }
        
         public int StoreItemId { get; set; }
       

        public List<StoreAbility> Abilities { get; set; }

       
        public StoreItem()
        {
            StoreItemId = 1;
            Brand = "Nike";
            Size = 8;
           Model = "Airforce";
            Abilities = new List<StoreAbility>();
        }

//Override the tostring method to display object information
        //If you want to display the object information in a string format in multiple places
        //You can access this method by just doing (objectName).ToString()
        public override string ToString()
        {
            return $"===Item Info===\nBrand:  {Brand}\nModel: {Model}\nSize: {Size}\nStoreItemId:  {StoreItemId}\n==============";
        }
        
    }
}