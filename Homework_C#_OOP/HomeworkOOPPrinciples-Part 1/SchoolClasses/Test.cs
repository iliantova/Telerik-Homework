using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class Test
    {
        static void Main()
        {


            Disciplines newDiscipline = new Disciplines("Mathematics", 50, 20);
            Students newStudent = new Students("Nikolay", Guid.NewGuid());
            Teachers newTeacher = new Teachers("Ivan Ivanov");
            newTeacher.AddDiscipline(newDiscipline);
            Console.WriteLine(newDiscipline.ToString());
            Console.WriteLine(newStudent.ToString());
            Console.WriteLine(newTeacher.ToString());
            Console.WriteLine(newTeacher.GetComment());



        }
    }
}
