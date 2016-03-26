namespace Problem_3.Animal_hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Start
    {
        public static void Main(string[] args)
        {
            Kitten mila = new Kitten(3, "Mila");
            Tomcat topcho = new Tomcat(4, "Topcho");

            Tomcat tomcho = new Tomcat(7, "Tomcho");
            Kitten pisana = new Kitten(3, "Pisana");

            // Create arrays of different kinds of animals and calculate the average age of each kind of animal 
            // using a static method (you may use LINQ).

            Cat[] cats = {
                             new Cat(3, "Tom", Sex.male),
                             new Cat(2, "Rija", Sex.female),
                             new Cat(4, "Pijo", Sex.male)
                         };

            Dog[] dogs = {
                             new Dog(2, "Moly", Sex.female),
                             new Dog(3, "Dogcho", Sex.male),
                             new Dog(6, "Dogcho", Sex.male)
                         };

            Frog[] frogs = {
                               new Frog(1, "Iva", Sex.female),
                               new Frog(4, "Frogcho", Sex.male)
                           };

            Console.WriteLine("Cats avareage years: {0:0.00}", CalculateAverageYears(cats));
            Console.WriteLine("Dogs avareage years: {0:0.00}", CalculateAverageYears(dogs));
            Console.WriteLine("Frogs avareage years: {0:0.00}", CalculateAverageYears(frogs));
        }

        public static double CalculateAverageYears(IAnimal[] animals)
        {
            var catAveraveAge = animals.Average(a => a.Age);

            return catAveraveAge;
        }
    }
}
