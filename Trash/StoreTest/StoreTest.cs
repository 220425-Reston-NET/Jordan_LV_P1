// using PokeModel;
// using Xunit;

// namespace StoreTest
// {
//     public class StoreTest
//     {
//         //This is how C#/XUnit recognizes that this particular method will be a unit test
//         //Data annotations - They just add special metadata information that gives special properties to a particular class member

//         /// <summary>
//         /// Checks the validation for StoreId and sets with valid data (validData > 0)
//         /// </summary>
//         [Fact]
//         public void StoreId_Should_Set_ValidData()
//         {
//             //Arrange
//             StoreItem storeObj = new StoreItem();
//             int storeId = 28;

//             //Act
//             storeObj.storeItemID = StoreId;

//             //Assert
//             Assert.NotNull(storeObj.StoreID); 
//             Assert.Equal(storeId, storeObj.StoreID); 
//         }


//         /// <summary>
//         /// Checks the validation for StoreId and checks if it fails (invalidData < 0)
//         /// </summary>
//         /// <param name="p_storeId">The inline data being given</param>
//         [Theory]
//         [InlineData(-19)]
//         [InlineData(-1290)]
//         [InlineData(0)]
//         [InlineData(-12983)]
//         public void PokeId_Should_Fail_Set_InvalidData(int p_storeId)
//         {
//             //Arrange
//             StoreItem storeObj = new StoreItem();

//             //Act & Assert
//             Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() => 
//                 {
//                     storeObj.StoreID = p_storeId;
//                 }
//             );
//         }
//     }
// }