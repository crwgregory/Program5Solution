using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Picker
{

    class Student
    {
        public int Number { get; set; }
 

        public int Group { get; set; }

        public Student(int num, int group) { this.Number = num; this.Group = group; }

    }
    class Program
    {

        static int Person { get; set; }


        static int Group { get; set; }


        static void Main(string[] args)
        {
            pickGroups();

            Console.ReadKey();
        }


        static void pickGroups()
        {
            List<int> theGroupsList = new List<int>();
            Random rng = new Random();
            int classSize = 20;
            int numberOfGroups = 4;
            int sizeOfGroupOne = 0;
            int sizeOfGroupTwo = 0;
            int sizeOfGroupThree = 0;
            int sizeOfGroupFour = 0;
            

            for (int i = 0; i < classSize; i++)
            {
                bool notAssignedToGroup = true;
                while (notAssignedToGroup)
                    {
                        

                    int number = rng.Next(1, 5);
                    if (number == 1 && sizeOfGroupOne != 5)
                    {
                        List<Student> students = new List<Student>();
                        students.Add(new Student() {Person = i, Group = number});
                        sizeOfGroupOne++;
                        Console.WriteLine("Person " + i + " is assigned to group number " + number);
                        theGroupsList.Add(new int() { Person = i; Group = number} );
                        notAssignedToGroup = false;

                    }
                    else if (number == 2 && sizeOfGroupTwo != 5)
                    {
                        sizeOfGroupTwo++;
                        Console.WriteLine("Person " + i + " is assigned to group number " + number);
                        notAssignedToGroup = false;
                    }
                    else if (number == 3 && sizeOfGroupThree != 5)
                    {
                        sizeOfGroupThree++;
                        Console.WriteLine("Person " + i + " is assigned to group number " + number);
                        notAssignedToGroup = false;
                    }
                    else if (number == 4 && sizeOfGroupFour != 5)
                    {
                        sizeOfGroupFour++;
                        Console.WriteLine("Person " + i + " is assigned to group number " + number);
                        notAssignedToGroup = false;
                    }
                    else
                    {
                        Console.WriteLine("Person " + i + " is not assigned group");
                    }
                }
            }



        }



    }
}
