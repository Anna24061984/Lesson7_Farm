using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_Farm
{
    public class Cow
    {        
        public string Name { get; private set; }

        public int Weight { get; set; }
        public int MilkVolumePerDay { get; set; }
        public CowGender Gender { get; private set; }
        public Cow(CowGender gender, string name, int weight)
        {
            Gender = gender;
            Name = name;
            Weight = weight;
            MilkVolumePerDay = 0;
        }
        public Cow(CowGender gender, string name, int weight, int milkvolumeperday) : this(gender, name, weight)
        {
            MilkVolumePerDay = milkvolumeperday;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{CowGenderName(Gender)} по имени {Name} весом {Weight}.{(Gender == CowGender.Female ? ($" Дает {MilkVolumePerDay} литров молока.") : "")}");
        }

        public enum CowGender { Male, Female }
        static string CowGenderName(CowGender gender)
        {
            switch (gender)
            {
                case CowGender.Male: return "Бык";
                case CowGender.Female: return "Корова";
                default: return "Неизвестное значение";
            }
        }
    }
}
