    //  public ViewResult UseExtentionEnumerable()
    //     {
    //         // create and populate Shoppingcart
    //         ShoppingCart cart = new ShoppingCart
    //         {
    //             Products = new List<Product>
    //             {
    //                 new Product {Name = "",Price = 275M },
    //                 new Product {Name = "Lifejacket",Price = 48.95M },
    //                 new Product {Name = "Soccer ball",Price = 19.5M },
    //                 new Product {Name = "Corner flag",Price = 34.95M }
    //             }
    //         };

    //         Product[] productArray = {
    //                 new Product { Name = "Kayak", Price = 275M },
    //                 new Product { Name = "Lifejacket", Price = 48.95M },
    //                 new Product { Name = "Soccer ball", Price = 19.5M },
    //                 new Product { Name = "Corner flag", Price = 34.95M }
    //             };

    //         decimal cartTotal = cart.Totalprices();
    //         decimal arrayTotal = productArray.Totalprices();

    //         return View("Result", (object)String.Format("Total: {0:c}, Array Total: {1:c}", cartTotal, arrayTotal ));
    //     }