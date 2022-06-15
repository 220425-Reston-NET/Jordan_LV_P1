namespace StoreModel
{
    public class StoreAbility
     {
    
        private int _ItemQuantity;

        public int ItemQty
        {
            get { return _ItemQuantity; }
            set 
            {
                if (value > 0)
                {
                    _ItemQuantity = value;
                }
                else
                {
                    Console.WriteLine("QTY cannot be empty");
                }
            }
        }

         private int _ItemPrice;

        public int ItemPrice
        {
            get { return _ItemPrice; }
            set 
            {
                if (value > 0)
                {
                    _ItemPrice = value;
                }
                else
                {
                    Console.WriteLine("price cannot be negative");
                }
            }
        }

          private string _ItemMaterial;

        public string ItemMaterial
        {
            get { return _ItemMaterial; }
            set 
            {
                if (value.Length > 0)
                {
                    _ItemMaterial = value;
                }
                else
                {
                    Console.WriteLine("input cannot be empty");
                }
            }
        }

        
          private string _ItemColor;

        public string ItemColor
        {
            get { return _ItemColor; }
            set 
            {
                if (value.Length > 0)
                {
                    _ItemColor = value;
                }
                else
                {
                    Console.WriteLine("input cannot be empty");
                }
            }
        }
        
        public double Price { get; set; }
         public int Quantity { get; set; }
        public string Material { get; set; }
         public string Color { get; set; }
       
        public List<StoreAbility> Abilities { get; set; }

       
        public StoreAbility()
        {
            Price = 49.99;
            Quantity = 1;
            Color = "Black";
           Material = "Leather";
            Abilities = new List<StoreAbility>();
        }


        public override string ToString()
        {
            return $"=======\nColor: {Color}\nMaterial: {Material}\nPrice: {Price}\nQuantity: {Quantity}\n=======";
        }
    
    }
 }







