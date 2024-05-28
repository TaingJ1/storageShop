using StorageLib.Services;
using StorageLib.Models;


namespace StorageShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var itemShop = ItemService.Current;

            itemShop.AddOrUpdate(new Item
            {
                Name = "Food",
                Description = "A piece of food",
                Price = "4"
            });
            string managementMenuOption;
            do {

                Console.WriteLine("Inventory Management (I)");
                Console.WriteLine("Shop (S)");
                Console.WriteLine("Checkout (C)");

                managementMenuOption = Console.ReadLine(); //else used for null and all other input

                if (managementMenuOption == "I" || managementMenuOption == "i")
                {
                    Console.WriteLine("Inventory Management Page");
                    Console.WriteLine("Create(C), Read(R), Update(U), or Delete(D) an item? (E to Exit)");

                    string itemOption = Console.ReadLine();
                    if (itemOption == "C" || itemOption == "c")
                    {
                        Console.WriteLine("Input Name, Description, then Price.");
                        itemShop.AddOrUpdate(new Item
                        {
                            Name = Console.ReadLine(),
                            Description = Console.ReadLine(),
                            Price = Console.ReadLine(),
                            NumAvailable = 1
                        });
                    }
                    else if (itemOption == "R" || itemOption == "r")
                    {
                        itemShop?.Items?.ToList()?.ForEach(Console.WriteLine);
                    }
                    else if (itemOption == "U" || itemOption == "u")
                    {

                    }
                    else if (itemOption == "D" || itemOption == "d")
                    {
                        itemShop?.Items?.ToList()?.ForEach(Console.WriteLine);
                        Console.WriteLine("Which item to delete? (Input ID)");

                        //int deleteId = Convert.ToInt32(Console.ReadLine());

                            //if (itemShop.id == deleteId)
                            //{
                            //    itemShop.Delete(deleteId);
                            //    itemShop?.Items?.ToList()?.ForEach(Console.WriteLine);
                       //else
                       //{
                            //Console.WriteLine("Item of ID: [", +deleteId, "] not found");
                        //}
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option");
                    }
                }
                else if (managementMenuOption == "S" || managementMenuOption == "s")
                {
                    Console.WriteLine("Shop Page");
                    itemShop?.Items?.ToList()?.ForEach(Console.WriteLine);

                    Console.WriteLine("Add an item(A), Remove an item(R), or Checkout(C)?");
                    string shopOption = Console.ReadLine();
                    if (shopOption == "A" || shopOption == "a")
                    {
                        Console.WriteLine("Input the id of the item to add.");
                        int addItemId = Convert.ToInt32(Console.ReadLine());
                        //if
                    }
                    else if (shopOption == "R" || shopOption == "r")
                    {

                    }
                    else if (shopOption == "C" || shopOption == "c")
                    {

                    }


                }
                else if (managementMenuOption == "C" || managementMenuOption == "c")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (managementMenuOption != "C" || managementMenuOption != "c");










            //Checkout Procedure

            //itemShop?.Items?.ToList()?.ForEach(item.Price)
            //int cartTotal;
            //double taxTotal = (cartTotal * 0.07);
            //double finalTotal = (cartTotal + taxTotal);



            //Console.WriteLine("Subtotal: " + cartTotal);
            //Console.WriteLine("Taxes: " + taxTotal);
            //Console.WriteLine("Your Total: " + finalTotal);
        }
    }
}

