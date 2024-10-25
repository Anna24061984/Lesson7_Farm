using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Farm
{
    public class Farm
    {
        public string Address;
        public List<Cow> Cows;
        public List<Chicken> Chickens;
        public Farm(string address)
        { 
            Address = address;
            Cows = new List<Cow>();
            Chickens = new List<Chicken>();
        }
        public void AddChicken(Chicken chicken)
        { 
            Chickens.Add(chicken);
        }
        public void RemoveChicken(Chicken chicken)
        {
            Chickens.Remove(chicken);
        }

        public void AddCow(Cow cow)
        {
            Cows.Add(cow);
        }
        public void RemoveCow(Cow cow)
        {
            Cows.Remove(cow);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Ферма расположена по адресу: {Address}");
            int eggs = 0;
            foreach (var chicken in Chickens)
            {
                eggs += chicken.EggsPerMonth;
            }

            int milk = 0;
            foreach (var cow in Cows)
            {
                milk += cow.MilkVolumePerDay;
            }
            Console.WriteLine($"В месяц производит {eggs} яиц и {milk} литров молока.");
        }
    }
}
