using System;
using System.Collections.Generic;
using System.Text;

namespace Validation_of_Data
{
    class Person
    {
        public Person(string firstname, string lastname, int age, decimal salary)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Salary = salary;
        }

        private string firstname;
        private string lastname;
        private int age;
        private decimal salary;

        public string Firstname
        {
            get
            {
                return this.firstname;
            }
           set
           {
                if (value.Length<3)
                throw new ArgumentException("First name should not be less than 3 characters ");
                this.firstname = value;
           }
        }
        public string Lastname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Last name must not be blank");
                this.lastname = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
             set
             {            
                if(value<=0)
                throw new ArgumentException("Age cannot be zero or negative integer"); 
                this.age = value;
             }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
             set
            {
                if(value<460)
                throw new ArgumentException("salary cannot be less than 460 dollar!");
                this.salary = value;
            }
        }
         public override string ToString()
         {
             return $"{this.firstname}  {this.lastname} receives  {this.salary} dollars";
         }
    }
}

