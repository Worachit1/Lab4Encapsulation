using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_OOP //Encapsulation
{
    public class Person
    {
        private string name;
        private int age;
        private int birthyear;
        private double grade;


        public Person(string name , int bYear , double grade)
        {
            this.name = name;
            this.birthyear = bYear; 
            this.age = 2566 - bYear;
            this.grade = grade;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getName()
        {
            return this.name;
        }
        public double getGrade()
        {
            return this.grade;
        }
    }
}
