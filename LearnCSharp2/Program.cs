using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using Dapper;

namespace LearnCSharp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee { Id = 1567, Name = "Bayan" };
            var employee2 = new Employee { Id = 1, Name = "Bayan" };
            var employee3 = new Employee { Id = 107, Name = "Bayan" };

            var list = new List<Employee> { employee, employee2, employee3 };

            foreach (var item in list)
            {
                var properties = item.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    var skillAttribute = prop.GetCustomAttribute<SkillAttribute>();
                    if (skillAttribute is not null)
                    {
                        var value = prop.GetValue(item);
                        if (skillAttribute.IsValid(value))
                        {
                            //add error here
                            // prop.Name;
                            //skillAttribute.Max;
                            //skillAttribute.Min;
                        }
                    }
                }
            }

        }
    }

    [DebuggerDisplay("Id:{Id} - Name:{Name}")]
    public class Employee
    {


        [Skill(nameof(Id), 1, 100)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
    public enum Status
    {
        Open, Clase, Pending
    }


    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)] //AttributeUsage is Flag Enum
    public class SkillAttribute : Attribute
    {
        public SkillAttribute(string name, int min, int max)
        {
            Name = name;
            Min = min;
            Max = max;
        }
        public int Min { get; set; }
        public string Name { get; set; }
        public int Max { get; set; }
        public bool IsValid(object obj)
        {
            return (int)obj > Min && (int)obj < Max;
        }
    }

}