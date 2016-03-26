namespace Problem1.School_classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SchoolMain
    {
        public static void Main(string[] args)
        {
            Student ivan = new Student("Ivan", "Good student", 1);
            Student gosho = new Student("Gosho", 2);
            Student pesho = new Student("Pesho", 3);

            List<Student> studsList = new List<Student>();
            studsList.Add(ivan);
            studsList.Add(gosho);
            studsList.Add(pesho);

            Discipline mathematics = new Discipline("Mathematics", 5, 3);
            Discipline sport = new Discipline("Sport", 3, 3);
            
            List<Discipline> disps = new List<Discipline>();
            disps.Add(mathematics);
            disps.Add(sport);

            Teacher vancho = new Teacher("vancho", disps);
            Teacher doncho = new Teacher("doncho", disps);

            List<Teacher> teachersList = new List<Teacher>();
            teachersList.Add(vancho);
            teachersList.Add(doncho);

            Class newClass = new Class("best class", "A class", teachersList, studsList);
        }
    }
}
