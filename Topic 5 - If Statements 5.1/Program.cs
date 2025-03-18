namespace Topic_5___If_Statements_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Part 1");
            //int people = 20;
            //int cats = 30;
            //int dogs = 15;
            //Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            //if (people < cats)
            //    Console.WriteLine("Too many cats! The world is doomed!");
            //if (people > cats)
            //    Console.WriteLine("Not many cats! The world is saved!");
            //if (people < dogs)
            //    Console.WriteLine("The world is drooled on!");
            //if (people > dogs)
            //    Console.WriteLine("The world is dry!");
            //Console.WriteLine("Press ENTER to continue. ");
            //Console.ReadLine();
            //Console.Clear();
            //dogs += 5;  //Add 5 to dogs. What does dogs equal now?
            //Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            //if (people >= dogs)
            //    Console.WriteLine("People are greater than or equal to dogs.");
            //if (people <= dogs)
            //    Console.WriteLine("People are less than or equal to dogs.");
            //if (people == dogs)
            //    Console.WriteLine("People are dogs.");

            //string dinosaur;
            //Console.WriteLine("What famous dinosaur has three large horns?");
            //dinosaur = Console.ReadLine();
            //if (dinosaur.ToLower() == "triceratops")
            //    Console.WriteLine("You are correct!");

            //Console.WriteLine("Task 1");
            //string word;
            //Console.WriteLine("What is the magic word?");
            //word = Console.ReadLine();
            //if (word == "please")
            //    Console.WriteLine("You're welcome.");

            //string word;
            //Console.WriteLine("What is the magic word?");
            //word = Console.ReadLine();
            //if (word.ToLower() == "please")
            //    Console.WriteLine("You're welcome.");

            Console.WriteLine("Task 2");
            string name;
            int age;
            Console.WriteLine("Hey, what's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Ok, " + name + ", how old are you?");
            int.TryParse(Console.ReadLine(), out age);
            {
                if (age <= 16)
                    Console.WriteLine("You can't drive.");
                if (age <= 18)
                    Console.WriteLine("You can't vote.");
                if (age < 25)
                    Console.WriteLine("You can't rent a car.");
                if (age >= 25)
                    Console.WriteLine("You can do anything that's legal.");
            }



        }
    }
}
