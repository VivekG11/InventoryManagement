using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    interface InventoryInterface
    {
        public void Display(List<Utility.Rice> rice);
        public void Display(List<Utility.Pulse> pulses);
        public void Display(List<Utility.Wheat> wheat);
        public List<Utility.Rice> AddToInvemtory(List<Utility.Rice> riceList);
        public List<Utility.Pulse> AddToInvemtory(List<Utility.Pulse> pulseList);
        public List<Utility.Wheat> AddToInvemtory(List<Utility.Wheat> wheatList);
        public List<Utility.Rice> DeleteFromInvemtory(List<Utility.Rice> riceList);
        public List<Utility.Pulse> DeleteFromInvemtory(List<Utility.Pulse> pulseList);
        public List<Utility.Wheat> DeleteFromInvemtory(List<Utility.Wheat> wheatList);
        public List<Utility.Rice> EditInvemtory(List<Utility.Rice> riceList);
        public List<Utility.Pulse> EditInvemtory(List<Utility.Pulse> pulseList);
        public List<Utility.Wheat> EditInvemtory(List<Utility.Wheat> wheatList);

        public int CalPrice(int weight, int price);



    }
}
