// namespace StoreUI
// {
//     public class StoreItem
//      {

//   private string _ItemBrand;

//         //This is a property

//         public string _itemBrand
//         {
//             get { return _itemBrand; }
//             set 
//             { 
//                 if (value.Length > 0)
//                 {
//                     _itemBrand = value;
//                 }
//                 else
//                 {
                   
//                     Console.WriteLine("Invalid Input! ( value > 0 )");
//                 }
//             }
//         }

       

//           public string _itemModel
//         {
//             get { return _itemModel; }
//             set 
//             { 
//                 if (value.Length >0 )
//                 {
//                     _itemModel = value;
//                 }
//                 else
//                 {
                    
//                     Console.WriteLine("Even Numbers Only! ( value > 0 )");
//                 }
//             }
//         }

//  public int _ItemSize
//         {
//             get { return _ItemSize; }
//             set 
//             { 
//                 if (value >0 )
//                 {
//                     _ItemSize = value;
//                 }
//                 else
//                 {
                    
//                 }
//             }
//         }


    
//          public string Brand { get; set; }
//         public int Size { get; set; }
//         public string Model { get; set; }
//          public int StoreItemId { get; set; }
       

//         public List<StoreAbility> Ability { get; set; }

       
//         public StoreItem()
//         {
//             StoreItemId = 1;
//             Brand = "Nike";
//             Size = 8;
//            Model = "Airforce";
//             Ability = new List<StoreAbility>();
//         }

        
//      }
    
//     }
//     //      public string ItemBrand { get; set ;}
//     //        public string ItemSize { get; set ;}
//     //          public decimal ItemPrice { get; set ;}
//     //            public int StoreItemId { get; set ;}

//     //            public StoreItem ()
//     //            {
//     //                StoreItemId = 1;
//     //                Brand = "Nike";
                

//     //                Size = "9";
//     //                ItemPrice = 0.00M;
//     //            }

//     //             public StoreItem(string _NameBrand, string _ShoeSize, string StoreItemId, decimal ItemPrice)
//     //             {

//     //             }


//     //     private string storeItem;

//     //     public string GetStoreItem()
//     //     {
//     //         return storeItem;
//     //     }
