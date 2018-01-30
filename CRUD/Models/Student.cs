using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Student
    {
        public static List<Student> studlist = new List<Student>();
        public string Name;
        public string Surname;
        public string Group;
        public int Age;
        public Student(string _name, string _surname, int _age,string _group)
        {
            Name = _name;
            Surname = _surname;
            Age = _age;
            Group = _group;
            studlist.Add(this);
        }
    }
}