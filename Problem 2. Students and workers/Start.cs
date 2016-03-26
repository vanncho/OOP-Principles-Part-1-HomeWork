namespace Problem_2.Students_and_workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Start
    {
        public static void Main(string[] args)
        {
            Student ivan = new Student("Ivan", "Ivanov", 1);
            Student dragan = new Student("Dragan", "Draganov", 4);
            Student pesho = new Student("Pesho", "Peshov", 5);
            Student gosho = new Student("Gosho", "Goshov", 2);
            Student doncho = new Student("Doncho", "Donchev", 6);
            Student martin = new Student("Martin", "Martinov", 10);
            Student nikolai = new Student("Nikolai", "Nikolaev", 3);
            Student stefan = new Student("Stefan", "Stefanov", 7);
            Student maria = new Student("Maria", "Marieva", 9);
            Student penka = new Student("Penka", "Penkova", 8);

            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(ivan);
            listOfStudents.Add(dragan);
            listOfStudents.Add(pesho);
            listOfStudents.Add(gosho);
            listOfStudents.Add(doncho);
            listOfStudents.Add(martin);
            listOfStudents.Add(nikolai);
            listOfStudents.Add(stefan);
            listOfStudents.Add(maria);
            listOfStudents.Add(penka);

            Worker batSali = new Worker("Sali", "Salov", 400, 8);
            Worker gencho = new Worker("Gencho", "Genchev", 300, 8);
            Worker vatman = new Worker("Vatman", "Vatmanov", 250, 8);
            Worker picko = new Worker("Picko", "Pickov", 150, 4);
            Worker viktor = new Worker("Viktor", "Viktorov", 380, 8);
            Worker georgi = new Worker("Georgi", "Georgiev", 450, 8);
            Worker miro = new Worker("Miro", "Mirov", 320, 8);
            Worker boian = new Worker("Boian", "Boianov", 170, 4);
            Worker slavi = new Worker("Slavi", "Slavistia", 200, 4);
            Worker angel = new Worker("Angel", "Angelov", 200, 8);

            List<IHuman> listOfWorkers = new List<IHuman>();
            listOfWorkers.Add(batSali);
            listOfWorkers.Add(gencho);
            listOfWorkers.Add(vatman);
            listOfWorkers.Add(picko);
            listOfWorkers.Add(viktor);
            listOfWorkers.Add(georgi);
            listOfWorkers.Add(miro);
            listOfWorkers.Add(boian);
            listOfWorkers.Add(slavi);
            listOfWorkers.Add(angel);

            var sortedStudentsByGrade = listOfStudents.OrderBy(st => st.Grade);

            PrintHuman(sortedStudentsByGrade);

            Console.WriteLine();

            var workersSoftByMoneyPerHour = listOfWorkers.OrderByDescending(m => m.MoneyPerHour());

            PrintHuman(workersSoftByMoneyPerHour);

            Console.WriteLine();

            var studentsMerge = sortedStudentsByGrade.OrderBy(n => n.FirstName);

            var workersMerge = workersSoftByMoneyPerHour.OrderBy(n => n.LastName);

            var mergedList = studentsMerge.Union(workersMerge).OrderBy(st => st.FirstName);

            PrintHuman(mergedList);
        }

        private static void PrintHuman(IEnumerable<IHuman> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
        }
    }
}
