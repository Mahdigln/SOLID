using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class LiskovSubstitutionPrinciple
    {
        interface IBonus
        {
            decimal Bonus(decimal salary);
        }
        interface ITeacher
        {
            int EmpId { get; set; }
            string Name { get; set; }
            decimal GetSalary();
        }
        public abstract class Teacher : ITeacher, IBonus
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public Teacher(int id, string name)
            {
                this.EmpId = id;
                this.Name = name;
            }
            public abstract decimal GetSalary();
            public abstract decimal Bonus(decimal salary);
        }


        public class PermanentTeacher : Teacher
        {
            public PermanentTeacher(int id, string name) : base(id, name)
            {
            }
            public override decimal GetSalary()
            {
                return 10000;
            }
            public override decimal Bonus(decimal salary)
            {
                return salary * .2M;
            }
        }
        public class TemporaryTeacher : Teacher
        {
            public TemporaryTeacher(int id, string name) : base(id, name)
            {
            }
            public override decimal GetSalary()
            {
                return 10000;
            }
            public override decimal Bonus(decimal salary)
            {
                return salary * .1M;
            }
        }


        //This class will have no Bonus  
        public class ContractTeacher : ITeacher
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public ContractTeacher(int id, string name)
            {
                this.EmpId = id;
                this.Name = name;
            }
            public decimal GetSalary()
            {
                return 5000;
            }
        }


        class Example2
        {
            public static void Main()
            {
                //Getting the Bonus detail with Salary  
                Teacher teacher = new PermanentTeacher(101, "Zeko");
                Teacher teacher2 = new TemporaryTeacher(102, "Priyanka");
                Console.WriteLine("Employee ID: {0} Name: {1} Salary: {2} Bonus:{3}", teacher.EmpId, teacher.Name, teacher.GetSalary(), teacher.Bonus(teacher.GetSalary()));
                Console.WriteLine("Employee ID: {0} Name: {1} Salary: {2} Bonus:{3}", teacher2.EmpId, teacher2.Name, teacher2.GetSalary(), teacher2.Bonus(teacher2.GetSalary()));
                //Getting details without Bonus  
                List<ITeacher> teachers = new List<ITeacher>();
                teachers.Add(new PermanentTeacher(101, "Zeko"));
                teachers.Add(new TemporaryTeacher(102, "Priyanka"));
                teachers.Add(new ContractTeacher(103, "Partha"));
                foreach (var obj in teachers)
                {
                    Console.WriteLine("Employee ID: {0} Name: {1} Salary: {2} ", obj.EmpId, obj.Name, obj.GetSalary());
                }
                Console.ReadLine();
            }
        }
    }
}
