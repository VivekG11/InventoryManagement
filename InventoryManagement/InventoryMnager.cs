using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    class InventoryMnager
    {
        public int CalPrice(int weight,int price)
        {
            return weight * price;
        }

        public void DisplayItems(List<Utility.Rice> rice)
        {
            int totalRiceCost = 0;
            foreach(Utility.Rice i in rice)
            {
                Console.WriteLine("Name :"+i.name+"Weight :"+i.weight+" and Price  :"+i.price);
                totalRiceCost += CalPrice(i.weight, i.price);
            }
            Console.WriteLine("Total cost of Rice is :"+totalRiceCost);
        }
        public void DisplayItems(List<Utility.Pulse> pulses)
        {
            int totaPulsesCost = 0;
            foreach (Utility.Pulse i in pulses)
            {
                Console.WriteLine("Name :" + i.name + "Weight :" + i.weight + " and Price  :" + i.price);
                totaPulsesCost += CalPrice(i.weight, i.price);
            }
            Console.WriteLine("Total cost of Rice is :" + totaPulsesCost);
        }
        public void DisplayItems(List<Utility.Wheat> wheats)
        {
            int totalWheatCost = 0;
            foreach (Utility.Wheat i in wheats)
            {
                Console.WriteLine("Name :" + i.name + "Weight :" + i.weight + " and Price  :" + i.price);
                totalWheatCost += CalPrice(i.weight, i.price);
            }
            Console.WriteLine("Total cost of Rice is :" + totalWheatCost);
        }

        //Adding items into inventory
        public List<Utility.Rice> AddToInventory(List<Utility.Rice> riceList)
        {
            Utility.Rice utility = new Utility.Rice();
            Console.WriteLine("Enter name of rice :");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter weight of the rice :");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price of teh rice per kg :");
            utility.price = Convert.ToInt32(Console.ReadLine());
            riceList.Add(utility);
            Console.WriteLine("Rice named "+utility.name+" is added to the Inventory.");
            return riceList;
        }
        public List<Utility.Pulse> AddToInventory(List<Utility.Pulse> pulseList)
        {
            Utility.Pulse utility = new Utility.Pulse();
            Console.WriteLine("Enter name of pulse :");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter weight of the pulse :");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price of teh pulse per kg :");
            utility.price = Convert.ToInt32(Console.ReadLine());
            pulseList.Add(utility);
            Console.WriteLine("Pulse named " + utility.name + " is added to the Inventory.");
            return pulseList;
        }
        public List<Utility.Wheat> AddToInventory(List<Utility.Wheat> wheatList)
        {
            Utility.Wheat utility = new Utility.Wheat();
            Console.WriteLine("Enter name of Wheat :");
            utility.name = Console.ReadLine();
            Console.WriteLine("Enter weight of the Wheat :");
            utility.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price of the Wheat per kg :");
            utility.price = Convert.ToInt32(Console.ReadLine());
            wheatList.Add(utility);
            Console.WriteLine("wheat named " + utility.name + " is added to the Inventory.");
            return wheatList;
        }

        //Delete items fro inventory
        public List<Utility.Rice> DeleteFromInventory(List<Utility.Rice> riceList)
        {
            Utility.Rice utility = new Utility.Rice();
            Console.WriteLine("Enter the name of the rice to be deleted :");
            string nameOfRice = Console.ReadLine().ToLower();
            riceList.Remove(riceList.Find(item => item.name.ToLower().Equals(nameOfRice)));
            Console.WriteLine(nameOfRice+" is deleted form the invemtory.");
            return riceList;
        }
        public List<Utility.Pulse> DeleteFromInventory(List<Utility.Pulse> pulseList)
        {
            Utility.Pulse utility = new Utility.Pulse();
            Console.WriteLine("Enter the name of the Pulse to be deleted :");
            string nameOfPulse = Console.ReadLine().ToLower();
            pulseList.Remove(pulseList.Find(item => item.name.ToLower().Equals(nameOfPulse)));
            Console.WriteLine(nameOfPulse + " is deleted form the invemtory.");
            return pulseList;
        }
        public List<Utility.Wheat> DeleteFromInventory(List<Utility.Wheat> wheatList)
        {
            Utility.Wheat utility = new Utility.Wheat();
            Console.WriteLine("Enter the name of the Wheat to be deleted :");
            string nameOfWheat = Console.ReadLine().ToLower();
            wheatList.Remove(wheatList.Find(item => item.name.ToLower().Equals(nameOfWheat)));
            Console.WriteLine(nameOfWheat + " is deleted form the invemtory.");
            return wheatList;
        }
        public List<Utility.Rice> EditInventoy(List<Utility.Rice>riceList)
        {
            List<Utility.Rice> rList = DeleteFromInventory(riceList);
            return AddToInventory(rList);
        }
        public List<Utility.Pulse> EditInventoy(List<Utility.Pulse> pulseList)
        {
            List<Utility.Pulse> pList = DeleteFromInventory(pulseList);
            return AddToInventory(pList);
        }
        public List<Utility.Wheat> EditInventoy(List<Utility.Wheat> wheatList)
        {
            List<Utility.Wheat> wList = DeleteFromInventory(wheatList);
            return AddToInventory(wList);
        }
    }
}
