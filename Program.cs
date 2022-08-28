using System;
namespace Day5
{
    abstract class question
    {
        public int id { get; set; }
        public string body { get; set; }
        public int mark { get; set; }
        public abstract void show();
    }
    class mcq : question
    {
        public string [] choice { get; set; }
    
        public override void show()
        {
            Console.WriteLine($"\n{ id}- {body} ?({mark}marks) " );
            for (int i = 0; i < choice.Length; i++)
            {
                Console.Write($"\t => { choice[i]}");
            }
          
        }

    }
    class trueorfalse : question
    {
        public override void show()
        {
            Console.WriteLine($"\n{ id}- {body} ?({mark}marks) ");

            Console.WriteLine($"a- True  \t b- False");

        }
    }
    class Exam
    {
        public void show(question q)
        {
            q.show();
        }
    }

    class program
    {
        static void Main()
        {
         
            Console.WriteLine("=================Plz ,Enter Number Of Question MCQ?===============");
            int NumOfQuestionmcq = int.Parse(Console.ReadLine());

            mcq [] m = new mcq[NumOfQuestionmcq];
            for (int j = 0; j < NumOfQuestionmcq; j++)
            {
                m[j] = new mcq();
                Console.WriteLine("plz, enter your Question Id");
                m[j].id = int.Parse(Console.ReadLine());
                Console.WriteLine("plz, enter your Question Body");
                m[j].body = Console.ReadLine();
                Console.WriteLine($"plz , enter your Number of Choice ");
                int numofchoice = int.Parse(Console.ReadLine());
                string[] ChoiceFromUser = new string[numofchoice];
                for (int i = 0; i < ChoiceFromUser.Length; i++)
                {
                    Console.WriteLine($"plz , enter your Choice {i + 1}");
                    ChoiceFromUser[i] = Console.ReadLine();
                }
                Console.WriteLine("plz, enter your Question Mark");
                m[j].mark = int.Parse(Console.ReadLine());
                m[j].choice = ChoiceFromUser;
               
            }
           
            Console.WriteLine("Plz ,Enter Number Of Question T or F ?");
            int NumOfQuestiontf = int.Parse(Console.ReadLine());

            trueorfalse [] m2 = new trueorfalse[NumOfQuestiontf];
            for (int i = 0; i < NumOfQuestiontf; i++)
            {
                m2[i] = new trueorfalse();
                Console.WriteLine("plz, enter your Question Id");
                m2[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine("plz, enter your Question Body");
                m2[i].body = Console.ReadLine();
                Console.WriteLine("plz, enter your Question Mark");
                m2[i].mark = int.Parse(Console.ReadLine());
            }

            Exam E = new Exam();
            Console.WriteLine("\t \t=========Start Exam=========");
            Console.WriteLine();
             Console.WriteLine("===============Question MCQ=========================");
            foreach (mcq item in m)
            {
                E.show(item);
            }
              Console.WriteLine("\n===============Question True Or False =========================");
            foreach (trueorfalse item in m2)
            {
                E.show(item);
            }
            Console.WriteLine("\n\t \t=========End Exam=========");


        }
    }
}
