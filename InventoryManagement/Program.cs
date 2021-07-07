using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Data Manager........ ");
            InventoryMnager inventoryMnager = new InventoryMnager();
            string jsonPath = @"C:\Users\VIVEK\source\repos\InventoryManagement\InventoryManagement\Json.json";

            Utility utility = JsonConvert.DeserializeObject<Utility>(File.ReadAllText(jsonPath));
            Console.WriteLine("Enter an Option :");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter a number to select an Item to display :");
                 switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        inventoryMnager.DisplayItems(utility.riceList);
                        break;

                    case 2:
                        inventoryMnager.DisplayItems(utility.pulseList);
                        break; 

                    case 3:
                        inventoryMnager.DisplayItems(utility.wheatList);
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                }
                break;

                case 2:
                    Console.WriteLine( "Enter a number to select an item to add it in inventory managemnet :");
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        inventoryMnager.AddToInventory(utility.riceList);
                        File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                        break;

                    case 2:
                        inventoryMnager.AddToInventory(utility.pulseList);
                        File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                        break;

                    case 3:
                        inventoryMnager.AddToInventory(utility.wheatList);
                        File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                        break;

                    case 4:
                        Console.WriteLine("Exit...");
                        break;
                }
                break;
               
                case 3:
                    Console.WriteLine("Enter an element to select an item to edit :");
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        inventoryMnager.EditInventoy(utility.riceList);
                        File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                        break;

                    case 2:
                        inventoryMnager.EditInventoy(utility.pulseList);
                        File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                        break;

                    case 3:
                        inventoryMnager.EditInventoy(utility.wheatList);
                        File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                        break;
                    case 4:
                        Console.WriteLine("Exit...");
                        break;
                }
                break;

                case 4:
                    Console.WriteLine("Enter a number to select an item to delete :");
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                        case 1:
                    inventoryMnager.DeleteFromInventory(utility.riceList);
                    File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                    break;

                        case 2:
                            inventoryMnager.DeleteFromInventory(utility.pulseList);
                            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                            break;

                        case 3:
                            inventoryMnager.DeleteFromInventory(utility.wheatList);
                            File.WriteAllText(jsonPath, JsonConvert.SerializeObject(utility));
                            break;

                        case 4:
                            Console.WriteLine("exit...");
                            break;


                }
                    break;
                case 5:
                    Console.WriteLine("Exit...");
                    break;
            }
        }
    }
}
