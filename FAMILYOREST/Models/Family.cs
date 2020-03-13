using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMILYOREST.Models
{



    public class Family : Person

    {

        public Family()
        {
            Children = new List<Person>();
        }

        public int FamilyId { get; set; }

        public string NickName { get; set; }

        public Adult Father { get; set; }

        public Adult Mother { get; set; }

        public List<Person> Children { get; set; }



        public int AverageAge
        {
            get

            {
                var age = Mother.Age + Father.Age;

                foreach (var Child in Children)
                {
                    age += Child.Age;
                }

                int totalFamilymember = 2 + Children.Count();

                return age / totalFamilymember;

            }

        }

        public int AverageFamilyAge
        { 
            get 
            
            {
                var averagefamilyage = Mother.Age + Father.Age;

                foreach (var Child in Children)
                {
                    averagefamilyage += Child.Age;
                }

                int totalfamilyage = 2 + Children.Count;

                return totalfamilyage / averagefamilyage;
            }

        }

        public Person YoungestChild
        {
            get

            {
                if (!this.Children.Any()) {
                    return null;
                }

                Person youngestChild = Children[0];

                foreach (var child in Children)
                {
                    if (child.Age < youngestChild.Age)
                    {
                        youngestChild = child;
                    }
                }

                return youngestChild;

            }
        }




        public Person OldestChild
        {
            get

            {
                if (this.Children.Count == 0)
                {
                    return null;
                }

                Person oldestChild = Children[0];

                foreach (var child in Children)
                {
                    if (child.Age > oldestChild.Age)
                    {
                        oldestChild = child;
                    }
                }

                return oldestChild;

                //var age = Mother.Age + Father.Age;

                //foreach (var Child in Children)
                //{
                //    age = age + Child.Age;
                //}

                //int totalFamilymember = 2 + Children.Count();



            }

        }








        public override string ToString()
        {
            var separator = "     ";

            var builder = new StringBuilder();


            builder.AppendLine($"Family {NickName} {FamilyId}");

            builder.AppendLine($"{separator}Parent");

            builder.AppendLine($"{separator}{separator}{Father.Name} - {DateTime.Now.Year - Father.DateOfBirth.Year}, {Father.Job}, LisenceNumber={Father.drlc}");
            builder.AppendLine($"{separator}{separator}{Mother.Name} - {DateTime.Now.Year - Mother.DateOfBirth.Year}, {Mother.Job}, LisenceNumber= \"{Mother.drlc}\"");

            builder.AppendLine($"{separator}Kids");

            foreach (var child in Children)

            {
                builder.AppendLine($"{separator}{separator}{child.Name} - {DateTime.Now.Year - child.DateOfBirth.Year}");
                    
           }

            return builder.ToString();
        }


    }
}
