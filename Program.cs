using System;
using System.Collections;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryStoreDiscountCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList();
            CannedGoods cg = new CannedGoods();
            Fruits fruit = new Fruits();


            while (true)
            {
                Console.WriteLine("====== GROCERY MENU CATEGORIES ======");
                Console.WriteLine("[1] Canned Goods");
                Console.WriteLine("[2] Meat");
                Console.WriteLine("[3] Fruits");
                Console.WriteLine("[4] Vegetables");
                Console.WriteLine("[5] Snacks");
                Console.WriteLine("[6] Sweets");
                Console.WriteLine("[7] Sauces and Condiments");
                Console.WriteLine("[8] Beverages");
                Console.WriteLine("[9] Personal Care");
                Console.WriteLine("[10] Household and Cleaning");
                Console.WriteLine("[x] View Cart");
                Console.WriteLine("=====================================");
                Console.Write("Enter the number of your choice: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        cg.cgMenu();
                        break;
                    case "2":
                        break;
                    case "3":
                        fruit.fruitsMenu();
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;

                }
            }
        }
    }
    /*
     //ADD, REMOVE
     // SHOW PRICE OF EACH ITEM AND THE SUBTOTAL
     // MAG MINUS FOR DISCOUNTS DEPENDING ON THE AMOUNT
     // -ONCE CONFIRMED OR CUSTOMER AGREE TO CHECK OUT, PRINT RECEIPT
     //[RECEIPT : QUANTITY , PRODUCT, PRICE, SUBTOTAL, DISCOUNT , TOTAL]
    */
    public class AddCart {
        public void addCart(object[] product) {
            ArrayList addTOCart = new ArrayList();
            addTOCart.Add(product);

        }
        public void showCart() {
            //
        }
    } 
    public class CannedGoods
    {
        public void cgMenu()
        {
            AddCart cart = new AddCart();
            ArrayList products = new ArrayList()
            {
                new object[] { "555 Sardines Spanish Style (155g)", 90.00, 0 },
                new object[] { "555 Sardines Tomato Sauce with Chili (15oz)", 198.00, 0 },
                new object[] { "Argentina Luncheon Meat (12oz)", 330.00, 0 },
                new object[] { "Blue Bay Fried Sardines Hot & Spicy", 82.00, 0},
                new object[] { "Blue Bay Sardines in Tomato Sauce", 82.00, 0 },
                new object[] { "Century Club Can Premium Sardines in Olive Oil", 180.00, 0 },
                new object[] { "Century Club Can Premium Sardines in Tomato Sauce", 180.00, 0 },
                new object[] { "Century Tuna - Corned Tuna Style", 170.00, 0 },
                new object[] { "Century Tuna - Chili Corned Tuna Style", 180.00, 0 },
                new object[] { "Century Tuna - Tuna Adobo Style", 136.00, 0 },
                new object[] { "Century Tuna - Tuna Afritada Style", 163.00, 0 },
                new object[] { "Century Tuna - Tuna Caldereta Style", 163.00, 0 },
                new object[] { "Century Tuna - Tuna Flakes in Soya Oil", 190.00, 0 },
                new object[] { "Century Tuna - Tuna Hot & Spicy Style", 200.00, 0 },
                new object[] { "Century Tuna - Tuna Mechado Style", 180.00, 0 },
                new object[] { "Century Tuna - Tuna with Calamansi (Lime)", 210.00, 0 },
                new object[] { "Ligo Sardines in Tomato Sauce Extra Hot", 50.00, 0 },
                new object[] { "Ligo Sardines Regular (Green, Small)", 92.00, 0 },
                new object[] { "Ligo Sardines with Chili (Red, Small)", 95.00, 0 },
                new object[] { "Maling Luncheon Meat Premium", 290.00, 0 }
            };
            Boolean valid = true;
            while (valid) {
                Console.WriteLine("================================ CANNED GOODS ================================");
                Console.WriteLine("[0] Search an Item");
                Console.WriteLine("===== PRODUCT ==================================================== PRICE =====");

                for (int i = 0; i < products.Count; i++)
                {
                    object[] product = (object[])products[i];
                    Console.WriteLine($"{i + 1,2}. {product[0],-60} PHP {product[1],8:F2}");
                }
                Console.WriteLine("[x] Returnt to Main Menu");
                Console.WriteLine("==============================================================================");
                Console.Write("Enter product number: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Name of product: ");
                        string search = Console.ReadLine();

                        Console.WriteLine("===== PRODUCT ==================================================== PRICE =====");
                        foreach (object[] product in products) {
                            string productName = product[0].ToString().ToLower();
                            if (productName.StartsWith(search))
                            {
                                Console.WriteLine($"{product[0],-60} PHP {product[1],8:F2}");
                                valid = true;
                            }
                        }

                        Console.Clear();
                        if (!valid)
                        {
                            Console.WriteLine("[Stock not available!]");
                        }
                        break;
                    case "1":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("Enter 1 to set quantity or 2 to return: ");
                        string input = Console.ReadLine();

                        if (input.Equals("1")) {
                            object[] product = (object[])products[0];

                            Console.WriteLine("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();

                            product[3] = quantity1;
                            cart.addCart(product);
                        }
                        if (input.Equals("2")) {
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                        Console.WriteLine("[1]Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("Enter 1 to set quantity or 2 to return: ");
                        string quantity2 = Console.ReadLine();
                        break;
                    case "3":
                        
                        break;
                    case "x":
                        Console.WriteLine();
                        valid = false;
                        break;
                }
            }
        }
    }
    public class Fruits{
        public void fruitsMenu()
        {
            while (true)
            {
                ArrayList fruitList = new ArrayList{
                    new object[] {"Apple", 20.01},
                    new object[] {"Banana", 30.00},
                    new object[] {"Grapes", 60.00},
                    new object[] {"Mango", 50.00},
                    new object[] {"Orange", 40.00},
                    new object[] {"Papaya", 45.00},
                    new object[] {"Strawberry", 55.00},
                    new object[] {"Watermelon", 35.00}
                };

                Console.WriteLine("============= FRUITS =============");
                for (int i = 0; i < fruitList.Count; i++) {
                    object[] fruit = (object[]) fruitList[i];
                    Console.WriteLine($"{i + 1,2}. {fruit[0],-15} PHP {fruit[1],8:F2}");
                }
                Console.WriteLine("[x] Return to Main Menu");
                Console.WriteLine("=================================");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter an item (fruit) to search: ");
                        string userFruit = Console.ReadLine();

                        bool found = false;

                            foreach (object[] item in fruitList) { 
                                string fruitName = item[0].ToString().ToLower();
                                if (fruitName.StartsWith(userFruit)){
                                        Console.WriteLine($"Item: {item[0]} Price: Php {item[1]}");
                                        found = true;
                                       // break;
                                }
                            } 
                        if (!found){
                            Console.WriteLine("Item not found.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter Quantity: ");
                        int appleQuantity = Convert.ToInt16(Console.ReadLine());
                        break;
                    case "3":
                        Console.WriteLine("Enter Quantity: ");
                        int bananaQuantity = Convert.ToInt16(Console.ReadLine());
                        break;
                    case "4":
                        Console.WriteLine("Enter Quantity: ");
                        int grapesQuantity = Convert.ToInt16(Console.ReadLine());
                        break;
                    case "5":
                        Console.WriteLine("Enter Quantity: ");
                        int mangoQuantity = Convert.ToInt16(Console.ReadLine());
                        break;
                    case "6":
                        Console.WriteLine("Enter Quantity: ");
                        int orangeQuantity = Convert.ToInt16(Console.ReadLine());
                        break;
                    case "7":
                        Console.WriteLine("Enter Quantity: ");
                        int papayaQuantity = Convert.ToInt16(Console.ReadLine());
                        break;
                    case "8":
                        Console.WriteLine("Enter Quantity: ");
                        int strawberryQuantity = Convert.ToInt16(Console.ReadLine());
                        break;
                    case "9":
                        Console.WriteLine("Enter Quantity: ");
                        int watermelonQuantity = Convert.ToInt16(Console.ReadLine());
                        break;
                    case "x":
                    case "X":
                        Console.Write("Returning to Main Menu.");
                        try
                        {
                            Thread.Sleep(1000);
                        }
                        catch (Exception e)
                        {
                        }
                        Console.Write(".");
                        try
                        {
                            Thread.Sleep(500);
                        }
                        catch (Exception e)
                        {
                        }
                        Console.Write(".");
                        try
                        {
                            Thread.Sleep(1000);
                        }
                        catch (Exception e)
                        {
                        }
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }



}

