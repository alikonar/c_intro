using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pushup  3 Cal   x20  
            //Airsquat 4 Cal x30
            //Muscle Up 10 Cal x20
            //Pistol Squat 6 Cal x20
            //Burpees 8 Cal x20

            Fitness workout1 = new Fitness();
            workout1.workout = "Push Up";
            workout1.rep = 20;
            workout1.cal = 3;

            Fitness workout2 = new Fitness();
            workout2.workout = "Air Squat";
            workout2.rep = 30;
            workout2.cal = 4;

            Fitness workout3 = new Fitness();
            workout3.workout = "Muscle Up";
            workout3.rep = 20;
            workout3.cal = 10;

            Fitness workout4 = new Fitness();
            workout4.workout = "Pistol Squat";
            workout4.rep = 20;
            workout4.cal = 6;

            Fitness workout5 = new Fitness();
            workout5.workout = "Burpees";
            workout5.rep = 20;
            workout5.cal = 8;

            Fitness[] workouts = new Fitness[] { workout5, workout1, workout4, workout2, workout3 };


            Console.WriteLine("-----------------While-------------");
            int w = 0;
            while (w<workouts.Length)
            {
                Console.WriteLine(workouts[w].workout + "    x" + workouts[w].rep + "  " + workouts[w].cal + " =Kalori");
                w++;
           
            }
            Console.WriteLine("--------------FOR--------------");
            for (int i = 0; i <workouts.Length ; i++)
            {
                Console.WriteLine(workouts[i].workout + "    x" + workouts[i].rep + "  " + workouts[i].cal + " =Kalori");

            }
            Console.WriteLine("----------foreach-------");
            foreach (Fitness idman in workouts)
            {
                Console.WriteLine(idman.workout + "   x" + idman.rep + "  " +"Kalori="+ idman.cal);

            }


        }
    }

    class Fitness
    {
        public string workout { get; set; }
        public int cal { get; set; }
        public int rep { get; set; }
    }
}
