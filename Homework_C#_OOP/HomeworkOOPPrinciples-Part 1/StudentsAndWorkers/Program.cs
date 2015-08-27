using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main()
        {
            List<Students> studentsList = new List<Students>();
            List<Workers> workersList = new List<Workers>();
            try
            {
                Students newStudent00 = new Students("Ivan", "Ivanov", 2.5);
                studentsList.Add(newStudent00);
                Students newStudent01 = new Students("Petar", "Petrov", 2.0);
                studentsList.Add(newStudent01);
                Students newStudent02 = new Students("Todor", "Todorov", 4.5);
                studentsList.Add(newStudent02);
                Students newStudent03 = new Students("Mihail", "Mihailov", 5.5);
                studentsList.Add(newStudent03);
                Students newStudent04 = new Students("Nikola", "Nikolov", 6.0);
                studentsList.Add(newStudent04);
                Students newStudent05 = new Students("Georgi", "Georgiev", 4.0);
                studentsList.Add(newStudent05);
                Students newStudent06 = new Students("Martin", "Martinov", 4.0);
                studentsList.Add(newStudent06);
                Students newStudent07 = new Students("Stoyan", "Stoyanov", 3.5);
                studentsList.Add(newStudent07);
                Students newStudent08 = new Students("Angel", "Angelov", 3.0);
                studentsList.Add(newStudent08);
                Students newStudent09 = new Students("Andrey", "Andreev", 5.0);
                studentsList.Add(newStudent09);

                Workers newWorker00 = new Workers("Ivaylo", "Ivailov", 8, 5, 348);
                workersList.Add(newWorker00);
                Workers newWorker01 = new Workers("Krastio", "Krastov", 12, 5, 487);
                workersList.Add(newWorker01);
                Workers newWorker02 = new Workers("Nikolay", "Nikolov", 4, 5, 243);
                workersList.Add(newWorker02);
                Workers newWorker03 = new Workers("Emil", "Emilov", 8, 3, 265);
                workersList.Add(newWorker03);
                Workers newWorker04 = new Workers("Vasil", "Vasilev", 12, 3, 215);
                workersList.Add(newWorker04);
                Workers newWorker05 = new Workers("Krasimir", "Krasimirov", 6, 5, 285);
                workersList.Add(newWorker05);
                Workers newWorker06 = new Workers("Vlado", "Vladimirov", 8, 5, 335);
                workersList.Add(newWorker06);
                Workers newWorker07 = new Workers("Svetlin", "Svetlinov", 4, 5, 324);
                workersList.Add(newWorker07);
                Workers newWorker08 = new Workers("Atanas", "Atanasov", 12, 5, 217);
                workersList.Add(newWorker08);
                Workers newWorker09 = new Workers("Boris", "Borisov", 6, 5, 352);
                workersList.Add(newWorker09);

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Students list by grade:");
                Console.WriteLine("----------------------------------");
                var studentsByGrade = studentsList.OrderBy(x => x.Grade);
                foreach (var student in studentsByGrade)
                {
                    Console.WriteLine(student.ToString());
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Workers list by salary per hour:");
                Console.WriteLine("----------------------------------");
                var workersByMoneyPerHour = workersList.OrderByDescending(x => x.MoneyPerHour());
                foreach (var worker in workersByMoneyPerHour)
                {
                    Console.WriteLine(worker.ToString());
                }

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Both lists together by name:");
                Console.WriteLine("----------------------------------");
                var allHumanList = studentsList.Cast<Human>().Union(workersList.Cast<Human>());
                List<Human> result = allHumanList.OrderBy(x => x.FirstName).ThenBy(y => y.LastName).ToList();
                foreach (Human human in result)
                {
                    Console.WriteLine(human.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
