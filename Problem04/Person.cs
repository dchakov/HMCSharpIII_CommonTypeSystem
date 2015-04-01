using System;

namespace Problem04
{
    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
               
        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative or over 120");
                }
                this.age = value;
            }
                
        }
        public Person(string name,int? age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name = {0} Age = {1}", this.Name, "not specified");
            }
            else
            {
                return string.Format("Name = {0} Age = {1}", this.Name, this.Age);
            }
            
        }

    }
}
