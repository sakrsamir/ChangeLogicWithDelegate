using System.Collections.Generic;

namespace DelegateTips
{
    delegate bool FindDelegate(Student student);

    class ChangeLogicWithDelegate
    {
        public static bool logicForFind(Student student)
        {
            return student.age > 10;
        }

        /* using 
        List<Student> list = s.Find(logicForFind);
            foreach (Student item in List)
            {
                System.Console.WriteLine(item);
            }
       */
    }

    class Student
    {
        public string Name;
        public int age;
        public override string ToString()
        {
            return Name + " - " + age;
        }
    }
    class Students
    {
        List<Student> lst = new List<Student>()
       {
           new Student{Name="Ahmed",age=20},
           new Student{Name="Mohamed",age=22},
           new Student{Name="Salah",age=24},
           new Student{Name="Hany",age=26},
           new Student{Name="Kareem",age=28}
       };

        public List<Student> Find(FindDelegate findDelegate)
        {
            List<Student> result = new List<Student>();
            foreach (Student item in lst)
            {
                if (findDelegate(item))
                    result.Add(item);
            }
            return result;
        }
    }
}
