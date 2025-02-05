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
            AddCart cart = new AddCart();
            CannedGoods cg = new CannedGoods(cart);
            Fruits fruit = new Fruits();

            Boolean valid = true;
            while (valid)
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
                    case "x":
                        cart.showCart();
                        break;
                    default:
                        Console.WriteLine("\n----------- INVALID INPUT> PLEAASE TRY AGAIN -----------\n");
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
    public class AddCart
    {
        ArrayList addToCart = new ArrayList(); 

        public void addCart(object[] product)
        {
            addToCart.Add(product);
            Console.WriteLine("\n------- Product added to cart! -------\n");
        }

        public void showCart()
        {
            Console.WriteLine("\n================================ YOUR CART ==================================");
            if (addToCart.Count == 0)
            {
                Console.WriteLine("Your cart is empty...");
            }
            else
            {
                foreach (object[] product in addToCart)
                {
                    Console.WriteLine($"{product[0],-50} PHP {product[1],8:F2}  Quantity: {product[2]}");
                }
            }
            Console.WriteLine("=============================================================================\n\n");
        }
    }
    public class CannedGoods
    {
        private AddCart cart; 
        public CannedGoods(AddCart cart)
        {
            this.cart = cart;  
        }

        public void cgMenu()
        {         

            ArrayList products = new ArrayList()
            {
                new object[] { "555 Sardines Spanish Style (155g)", 90.00, 0 },
                new object[] { "555 Sardines Tomato Sauce with Chili (15oz)", 198.00, 0 },
                new object[] { "Argentina Luncheon Meat (12oz)", 330.00, 0 },
                new object[] { "Blue Bay Fried Sardines Hot & Spicy", 82.00, 0},
                new object[] { "Blue Bay Sardines in Tomato Sauce", 82.00, 0 },
                new object[] { "Century Club Can Premium Sardines in Olive Oil", 180.00, 0 },                   
                new object[] { "Century Tuna - Tuna with Calamansi (Lime)", 210.00, 0 },                
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
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input = Console.ReadLine();

                        if (input.Equals("1")) {
                           object[] product = (object[])products[0];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);                  
                            continue;
                        }
                        if (input.Equals("2")) {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "2":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input1 = Console.ReadLine();

                        if (input1.Equals("1"))
                        {
                            object[] product = (object[])products[1];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);                            
                            continue;
                        }
                        if (input1.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "3":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input2 = Console.ReadLine();

                        if (input2.Equals("1"))
                        {
                            object[] product = (object[])products[2];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input2.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "4":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input3 = Console.ReadLine();

                        if (input3.Equals("1"))
                        {
                            object[] product = (object[])products[3];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input3.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "5":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input4 = Console.ReadLine();

                        if (input4.Equals("1"))
                        {
                            object[] product = (object[])products[4];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input4.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "6":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input5 = Console.ReadLine();

                        if (input5.Equals("1"))
                        {
                            object[] product = (object[])products[5];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input5.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "7":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input6 = Console.ReadLine();

                        if (input6.Equals("1"))
                        {
                            object[] product = (object[])products[6];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input6.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "8":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input7 = Console.ReadLine();

                        if (input7.Equals("1"))
                        {
                            object[] product = (object[])products[7];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input7.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "9":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input8 = Console.ReadLine();

                        if (input8.Equals("1"))
                        {
                            object[] product = (object[])products[8];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input8.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
                        break;
                    case "10":
                        Console.WriteLine("[1]Input Quantity");
                        Console.WriteLine("[2] return");
                        Console.Write("\nEnter 1 to set quantity or 2 to return: ");
                        string input9 = Console.ReadLine();

                        if (input9.Equals("1"))
                        {
                            object[] product = (object[])products[9];

                            Console.Write("How many would you like to buy: ");
                            string quantity1 = Console.ReadLine();
                            Console.Clear();
                            product[2] = quantity1;
                            cart.addCart(product);
                            continue;
                        }
                        if (input9.Equals("2"))
                        {
                            Console.Clear();
                            continue;
                        }
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

