using System;

namespace Problem3.Mankind
{
    class StartUp
    {
        static void Main()
        {
			var studentInput = Console.ReadLine().Split();
			var name = studentInput[0];
			var lastName = studentInput[1];
			var facultyNumber = studentInput[2];

			Student student = new Student(name, lastName, facultyNumber);

			var workerInput = Console.ReadLine().Split();
			var firstName = workerInput [0];
			var LastName = workerInput[1];
			var weekSalary = decimal.Parse(workerInput[2]);
			var workHours = int.Parse(workerInput[3]);

			Worker worker = new Worker(firstName, LastName, weekSalary, workHours);

			Console.WriteLine(student);
			Console.WriteLine(worker);
		}
    }
}
