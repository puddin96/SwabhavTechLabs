using System;
using PersonBMIApp;

namespace PersonBMIApp
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy1()
        {
            Person p1 = new Person("Shivam", "Male", 30f, 75f, 25);
            PrintPersonDetails(p1);
            p1.Eat();
            PrintPersonDetails(p1);
            p1.Workout();
            PrintPersonDetails(p1);
            p1.Bmi();
            PrintBMI(p1);
        }

        public static void CaseStudy2()
        {
            Person[] manyPerson = new Person[3];
            Person p1 = new Person("Shivam Sutar", "Male", 72f, 75f, 25);
            Person p2 = new Person("Akshay Sawant","Male", 68f, 100f, 24);
            Person p3 = new Person("Siddhesh Chikane", "Male",65f,  50f, 23);
            manyPerson[0] = p1;
            manyPerson[1] = p2;
            manyPerson[2] = p3;

            p1.Eat();
            p1.Workout();
            p1.Bmi();
            PrintBMI(p1);
            PrintPersonDetails(manyPerson[0]);
            p2.Eat();
            p2.Bmi();
            PrintBMI(p2);
            PrintPersonDetails(manyPerson[1]);
            p3.Workout();
            p3.Bmi();
            PrintBMI(p3);
            PrintPersonDetails(manyPerson[2]);
        }
        

       /* public static void PrintPersonDetails(Person[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("Name           :      {0}", p[i].GetName());
                Console.WriteLine("Gender         :      {0}", p[i].GetGender());
                Console.WriteLine("Height         :      {0}", p[i].GetHeight());
                Console.WriteLine("Weight         :      {0}", p[i].GetWeight());
                Console.WriteLine("Age            :      {0}", p[i].GetAge());
                Console.WriteLine(" ");
            }
        }*/

        public static void PrintPersonDetails(Person p)
        {
            Console.WriteLine("Name              :      {0}", p.GetName());
            Console.WriteLine("Gender            :      {0}", p.GetGender());
            Console.WriteLine("Height in mtrs    :      {0}", p.GetHeight());
            Console.WriteLine("Weight in kgs     :      {0}", p.GetWeight());
            Console.WriteLine("Age               :      {0}", p.GetAge());

            if (p.GetBmi() < 20)
            {
                Console.WriteLine("Human is underweight");
                Console.WriteLine(" ");
            }
            else if (p.GetBmi() >= 20 && p.GetBmi() <= 25)
            {
                Console.WriteLine("Human is average");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Human is overweight");
                Console.WriteLine(" ");
            }
        }
        public static void PrintBMI(Person p)
        {
            Console.WriteLine("Bmi                :     {0}", p.GetBmi());
            Console.WriteLine(" ");

        }
    }
}
