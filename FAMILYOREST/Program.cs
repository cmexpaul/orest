using FAMILYOREST.Date;
using FAMILYOREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FAMILYOREST.Extentions;

namespace FAMILYOREST
{
    class Program
    {
        public static void Main(string[] args)
        {


            //foreach(var family in families)
            //{
            //    Console.WriteLine(family);
            //}

            var context = new DataContext();
            var families = context.Families;
            var test = new FamilyTester(families);

            List<Family> f = test.GetFamilyWithNoKids();

            List<Family> fmc = test.GetFamilyWithMostKids();

            List<Family> gfbn = test.GetFamilyByName("Jim");

            List<Family> gfwoc = test.GetFamilyWithOldestChild();

            List<Family> GYF = test.GetYoungestFamily();

            List<Family> YC = test.YoungestChild();

            var myName = "Orest";
            Console.WriteLine(myName.SayHello());

            var myzip = "1345";
            Console.WriteLine(myzip.ZipTest());



            //PrintFamilies(f);
            //PrintFamilies(fmc);
            //PrintFamilies(gfbn);
            //PrintFamilies(gfwoc);
            //PrintFamilies(GYF);
            PrintFamilies(YC);

            //foreach (var family in families)
            //{
            //    Console.WriteLine($"{family.Father.Name} - {family.Father.Age}");
            //}

            //foreach (var family in families)
            //{
            //    Console.WriteLine($"{family.FamilyId} {family.AverageAge}");
            //}



            Console.ReadLine();



            //var person = new Person();
            //person.FirstName = "Vasya";
            //person.LastName = "smith";



            //var message = person.FirstName + " " + person.LastName + " is AWESOME";
            //var message2 = string.Format("{0} {1} is awesome", person.FirstName, person.LastName);
            //message = $"{person.FirstName} {person.LastName} is awesome {person.FirstName}";


            //var builder = new StringBuilder("HELLO");
            //for (int i = 0; i < 100; i++)
            //{
            //    builder.Append("!");
            //}

            //Console.WriteLine(builder.ToString());


            //for (int i = 0; i < 100; i++)
            //{
            //    message += "!";

            //}

            //Console.WriteLine(message);

            //Console.WriteLine(message2);

        }


        public static void PrintFamily(Family family)
        {
            Console.WriteLine(family);
        }

        public static void PrintFamilies(List<Family> families)
        {
            foreach (var family in families) 
            { 

            PrintFamily(family);

            }
        }
    }
}
