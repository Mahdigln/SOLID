using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
   
    public abstract class Teacher
    {
        public int EmpId;
        public string Name;
        public Teacher(int id, string name)
        {
            this.EmpId = id;
            this.Name = name;
        }
        public abstract decimal Bonus(decimal salary);
    }

    public class PermanentTeacher : Teacher
    {
        public PermanentTeacher(int id, string name) : base(id, name)
        {
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
        public override decimal Bonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    class Example2
    {
        public static void Main()
        {
            Teacher teacher = new PermanentTeacher(101, "Zeko");
            Teacher teacher2 = new TemporaryTeacher(102, "Priyanka");
            Console.WriteLine("Employee ID: {0} Name: {1} Bonus: {2}", teacher.EmpId, teacher.Name, teacher.Bonus(10000));
            Console.WriteLine("Employee ID: {0} Name: {1} Bonus: {2}", teacher2.EmpId, teacher2.Name, teacher2.Bonus(10000));
            Console.ReadLine();
        }
    }
}
