

// namespace StoreModel
// {
//     public class Ability
//     {

        
//         private int _StoreItemId;
//         public int StoreItemId
//         {
//             get { return _StoreItemId; }
//             set
//             {
//                 if (value > 0)
//                 {
//                     _StoreItemId = value;
//                 }
//                 else
//                 {

//                 }
//             }
//         }





//         public string Brand { get; set; }

        
//         private string _ItemBrand;
//         public string ItemBrand
//         {
//             get { return _ItemBrand; }
//             set
//             {
//                 if (value.Length >3 )
//                 {
//                     _ItemBrand = value;
//                 }
//                 else
//                 {

//                 }
//             }
//         }

//         public string _itemBrand { get; set; }
      
      
//         public string Model { get; set; }

//         private string _ItemModel;
//         public string ItemModel
//         {
//             get { return _ItemModel; }
//             set
//             {
                
//                 if (value.Length >3 )
//                 {
//                     _ItemModel = value;
//                 }
//                 else
//                 {
                    
//                 }
//             }
//         }

//         public int _itemModel{ get; set; }

//     public string ItemInfo{ get; set; }
      
//         public string Size { get; set; }

//          private int _ItemSize;
//         public int Itemsize
//         {
//             get { return _itemSize; }
//             set
//             {
//                 if (value > 0)
//                 {
//                     _itemSize = value;
//                 }
//                 else
//                 {
                    
//                 }
//             }
//         }

//         public int _itemSize{ get; set; }

//                 public string Price { get; set; }

//          private int _ItemPrice;
//         public int ItemPrice
//         {
//             get { return _itemPrice; }
//             set
//             {
//                 if (value > 0)
//                 {
//                     _itemPrice = value;
//                 }
//                 else
//                 {
                    
//                 }
//             }
//         }

//         public int _itemPrice{ get; set; }




    

//        public  Ability()
    
//         {
//             StoreItemId = 1;
//             Brand = "Nike";
//             Size = "8";
//            Model = "Airforce";
//             ItemInfo = "";
//         }

// //Override the tostring method to display object information
//         //If you want to display the object information in a string format in multiple places
//         //You can access this method by just doing (objectName).ToString()
//         public override string ToString()
//         {
//             return $"===Store Item Info===\nBrand:  {Brand}\nName: {Size}\nMeasurement:  {Model}\n==============";
//         }
        


//    }

// }