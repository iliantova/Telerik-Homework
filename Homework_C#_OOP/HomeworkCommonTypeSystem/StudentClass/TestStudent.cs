using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class TestStudent
    {
        static void Main()
        {
            Student FirstStudent =new Student("Ivan", "Ivanov", 12154545, Specialty.Informatics , University.SofiaUniversity, Faculty.Mathematics );
            Student SecontStudent = new Student("Georgi", "Georgiev", 121545545, Specialty.Mathematics, University.SofiaUniversity, Faculty.Mathematics);
            Student ThirtStudent = new Student("Ivan", "Ivanov", 12154545,  Specialty.SoftwareEngineering, University.TehnicalUniversity, Faculty.Informatics, "second", "MiddleOfNothing St", "0897456123", "ivan_ivanov@abv.bg", "Georgiev" );


            Console.WriteLine("Is student equals:");
            Console.WriteLine(FirstStudent == SecontStudent);
            Console.WriteLine(FirstStudent==ThirtStudent);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Compare two students");
            Console.WriteLine(FirstStudent.CompareTo(ThirtStudent));
            Console.WriteLine();

            Console.WriteLine("Data for student:");
            Console.WriteLine(ThirtStudent.ToString());
            Console.WriteLine();
            Console.WriteLine("HashCode:");
            Console.WriteLine(FirstStudent.GetHashCode());
            Console.WriteLine(SecontStudent.GetHashCode());
        }
    }
}
