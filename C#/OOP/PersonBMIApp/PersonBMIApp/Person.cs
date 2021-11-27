using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBMIApp
{
    class Person
    {
        String _name;
        String _gender;
        float _height;
        float _weight;
        float _bmi;
        int _age;

        public Person(String name, String gender, float height, float weight, int age)
        {
            _name = name;
            _gender = gender;
            _height = height * 0.0254f;
            _weight = weight;
            _age = age;
        }

        public void Workout()
        {
            _weight = _weight - (10 * _weight) / 100;
            Console.WriteLine("Initiating Workout");
            Console.WriteLine("Weight Reduced by  10%");
            Console.WriteLine(" ");
        }

        public void Eat()
        {
            _height = _height + (2 * _height) / 100;
            _weight = _weight + (5 * _weight) / 100;
            Console.WriteLine("Ahhhh I am so full");
            Console.WriteLine("Height increased by 2%");
            Console.WriteLine("Weight increased by 5%");
            Console.WriteLine(" ");
        }
        public void Bmi()
        {
            _bmi = _weight / (_height * _height);
            Console.WriteLine("Here's your BMI");
        }

        public String GetName()
        {
            return _name;
        }
        public String GetGender()
        {
            return _gender;
        }
        public float GetHeight()
        {
            return _height;
        }
        public float GetWeight()
        {
            return _weight;
        }
        public float GetBmi()
        {
            return _bmi;
        }
        public int GetAge()
        {
            return _age;
        }
    }
}
