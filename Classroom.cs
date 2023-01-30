using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_OOP
{

    internal class Classroom
    {
        double maxgrade = 0;
        double mingrade = int.MaxValue;
        double iGrade = 0;
        string name;
        string namemax = "";
        string namemin = "";
        List<Person> persons = new List<Person>();

        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPerson2Class(Person p)
        {
            this.persons.Add(p);
        }
        public string showAllPersoninClass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\r\n";
            }
            return result;
        }
        public int showsumageinClass()
        {
            int sumage = 0;
            foreach (Person p in this.persons)
            {
                sumage += p.getAge();
            }
            return sumage;
        }
        public double avggradeinClass()
        {
            double avggrade = 0;
            int n = 0;
            foreach (Person p in this.persons)
            {
                avggrade += p.getGrade();
                n++;
            }
            return avggrade/n;
        }
        public double Maxgrade()
        {
            foreach(Person p in this.persons)
            {
                iGrade = p.getGrade();                
            }
            if (iGrade>maxgrade)
            {
                maxgrade = iGrade;
            }
            if (iGrade<mingrade)
            {
                mingrade = iGrade;
            }
            return maxgrade;
        }
        
        public double Mingrade()
        {
            foreach (Person p in this.persons)
            {
                iGrade = p.getGrade();
            }
            if (iGrade>maxgrade)
            {
                maxgrade = iGrade;
            }
            if (iGrade<mingrade)
            {
                mingrade = iGrade;
            } 
            return mingrade;
        }
        
        public string shownameminGPA()
        {
            
            foreach (Person p in this.persons)
            {
                name = p.getName();
                iGrade = p.getGrade();
            }
            if (iGrade>maxgrade)
            {
                maxgrade = iGrade;
            }
            if (iGrade<mingrade)
            {
                mingrade = iGrade;
            }
            if(iGrade==mingrade)
            {
                this.namemin = name;
            }
            return namemin;
        }
        
        public string shownamemaxGPA()
        {
            foreach (Person p in this.persons)
            {
                name = p.getName();
                iGrade = p.getGrade();
            }
            if (iGrade>maxgrade)
            {
                maxgrade = iGrade;
            }
            if (iGrade<mingrade)
            {
                mingrade = iGrade;
            }
            if(iGrade == maxgrade)
            {
                this.namemax = name;
            }
            return namemax;
        }

    }
}
