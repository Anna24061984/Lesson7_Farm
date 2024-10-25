using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Farm
{
    public class Chicken
    {
        public ChickenGender Gender { get; private set; }
        public int Number { get; private set; }
        public int EggsPerMonth { get; set; }

        public Chicken(int number)
        {
            Number = number;
            EggsPerMonth = 0;
            Gender = ChickenGender.Male;
        }
        public Chicken(int number, ChickenGender gender, int eggsPerMonth) :this(number)
        {            
            Gender = gender;
            EggsPerMonth = eggsPerMonth;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{ChickenGenderName(Gender)} номер {Number}.{(Gender == ChickenGender.Female ? ($" Несет {EggsPerMonth} яиц в месяц.") : "")}");
        }

        public enum ChickenGender { Male, Female }
        
        static string ChickenGenderName(ChickenGender gender)
        {
            switch (gender)
            {
                case ChickenGender.Male: return "Петух";
                case ChickenGender.Female: return "Курица";
                default: return "Неизвестное значение";
            }
        }
    }
}
