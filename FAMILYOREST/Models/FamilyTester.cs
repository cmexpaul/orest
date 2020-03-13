using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAMILYOREST.Models
{
    public class FamilyTester
    {
        private readonly List<Family> _data;

        public FamilyTester(List<Family> data) {
            _data = data;
        }


        public void Run() {

            //var family = new Family();
            //family.NickName = "Jonesss";
            //family.FamilyId = 1;

            //var father = new Adult();
            //father.FirstName = "PAVEL";
            //father.LastName = "BORISOV";
            //father.DateOfBirth = DateTime.Now.AddYears(-34);
            //family.Father = father;
            //father.drlc = "2344454";
            //father.Job = "Programmer";

            //var mother = new Adult();
            //mother.FirstName = "Valentinka";
            //mother.LastName = "Drobot";
            //father.DateOfBirth = DateTime.Now.AddYears(-20);
            //mother.Job = "NURSE";
            //mother.drlc = "888";
            //family.Mother = mother;

            //var child1 = new Child();
            //child1.FirstName = "Lexi";
            //child1.LastName = father.LastName;
            //child1.DateOfBirth = DateTime.Now.AddYears(-7);

            //family.Children.Add(child1);

            //var child2 = new Child();
            //child2.FirstName = "Pexi";
            //child2.LastName = father.LastName;
            //child2.DateOfBirth = DateTime.Now.AddYears(-4);

            //family.Children.Add(child2);

            //Console.WriteLine("Parents:");

            //var messagefather = father.FirstName + " - " + father.DOB ;

            //Console.WriteLine(messagefather);






            //Console.WriteLine(family.ToString());






            //    //    public override string ToString()
            //    //{
            //    var separator = "     ";
            //    var bulder = new StringBuilder();

            //    bulder.AppendLine($"Family {Nickname({Id})}");




            ////    return base.ToString();
            ////}





        }



        public List<Family> GetFamilyByName(string nameToFind) {
            List<Family> response = new List<Family>();

            foreach (var family in _data) {
                if (family.Father.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase)
                    || family.Mother.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase)) {
                    response.Add(family);
                }


                foreach (var familyChild in family.Children) {
                    if (familyChild.Name.Equals(nameToFind, StringComparison.CurrentCultureIgnoreCase)) {
                        response.Add(family);
                    }
                }

            }

            return response;
        }

        public List<Family> YoungestChild() {
            List<Family> response = new List<Family>();

            int youngestChildAge = 999;

            foreach (var family in _data) {
                if (family.YoungestChild != null && family.YoungestChild.Age < youngestChildAge) {
                    youngestChildAge = family.YoungestChild.Age;
                }
            }

            foreach (var family in _data) {
                if (family.YoungestChild != null && family.YoungestChild.Age == youngestChildAge) {
                    response.Add(family);
                }
            }
            return response;
        }

        public List<Family> GetYoungestFamily() {
            List<Family> response = new List<Family>();

            int YoungestFamilyAge = 99999;

            foreach (var family in _data) {
                if (family.AverageAge < YoungestFamilyAge) {
                    YoungestFamilyAge = family.AverageAge;

                    response.Add(family);
                }
            }

            return response;
        }

        public List<Family> GetFamilyWithOldestChild() {
            List<Family> response = new List<Family>();

            int oldestChildAge = 0;

            foreach (var family in _data) {
                if (family.OldestChild != null && family.OldestChild.Age > oldestChildAge) {
                    oldestChildAge = family.OldestChild.Age;
                }
            }


            // create extation method that will check if zip is 5 char long or 9, 


            foreach (var family in _data) {
                if (family.OldestChild != null && family.OldestChild.Age == oldestChildAge) {
                    response.Add(family);
                }
            }

            return response;
        }












        public List<Family> GetFamilyWithMostKids() {
            List<Family> response = new List<Family>();


            var maxNumberOfKids = 0;


            foreach (var family in _data) {

                if (family.Children.Count > maxNumberOfKids) {
                    maxNumberOfKids = family.Children.Count;
                }
            }



            foreach (var family in _data) {
                if (family.Children.Count == maxNumberOfKids) {
                    response.Add(family);
                }

            }

            return response;
        }

        public List<Family> GetFamilyWithNoKids() {
            List<Family> response = new List<Family>();

            foreach (var family in _data) {
                if (family.Children.Count == 0) {
                    response.Add(family);
                }
            }

            return response;
        }





    }
}
