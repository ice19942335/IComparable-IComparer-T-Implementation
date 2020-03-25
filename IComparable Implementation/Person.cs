using System;

namespace IComparable_Implementation
{
    public class Person : IComparable
    {
        public int _age;
        public double _height;
        public double _weight;

        public Person(int age, double height, double weight)
        {
            _age = age;
            _height = height;
            _weight = weight;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public double Weight
        {
            get => _weight;
            set => _weight = value;
        }


        public int CompareTo(object obj)
        {
            Person p = obj as Person;

            if (p != null)
            {
                if (Age < p.Age)
                    return -1;
                else if (Age > p.Age)
                    return 1;
                else
                    return 0;
            }
            else
            {
                throw new Exception("Param have to be type 'Person'");
            }
        }
    }
}