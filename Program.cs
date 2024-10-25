namespace Lesson7_Farm
{    
    internal class Program
    {   
        static void Main(string[] args)
        {            
            Farm MyFarm = new("г. Дивный, ул. Вишневая, д.135");    //создаем ферму
            MyFarm.AddChicken(new Chicken(1));                      
            MyFarm.AddChicken(new Chicken(2, Chicken.ChickenGender.Female, 20));
            MyFarm.AddChicken(new Chicken(3, Chicken.ChickenGender.Female, 25));
            MyFarm.AddChicken(new Chicken(4, Chicken.ChickenGender.Female, 22));                  
            MyFarm.AddCow(new Cow(Cow.CowGender.Male, "Нарцисс", 700));
            MyFarm.AddCow(new Cow(Cow.CowGender.Female, "Роза", 600, 15));
            MyFarm.AddCow(new Cow(Cow.CowGender.Female, "Ромашка", 580, 13));
            MyFarm.AddCow(new Cow(Cow.CowGender.Female, "Лилия", 620, 18));
            Console.WriteLine("Ферма запущена!");
            MyFarm.GetInfo();                                                                   

            Console.WriteLine("\nФерма понесла убытки!");
            MyFarm.RemoveChicken(MyFarm.Chickens[2]);
            MyFarm.RemoveCow(MyFarm.Cows[1]);
            MyFarm.GetInfo();                                                                   
            Console.ReadLine();
        }
                
    }
}

