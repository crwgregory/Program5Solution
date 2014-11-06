using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            groupMaker(18, 2);

            Console.ReadKey();
        }
        //to really make this program run the best way, I would need to learn how to get access to a database that holds the names of all the class members
        //then to loop through this and create the list that the program would use.
        //also if I have a number of people not divisable by the group size then It leaves thoughs people.
        static void groupMaker(int ClassSize, int GroupSize)
        {
            //create lists
            List<int> ClassList = new List<int>();
            List<int> GroupList = new List<int>();
            List<int> AlreadyUsedNumbers = new List<int>();
            Random GroupNumber = new Random();
            int WhatGroup = 1;

            //populates CLass list with class size
            for (int i = 0; i < ClassSize; i++)
			{
                int StudentNumber = i;
                ClassList.Add(StudentNumber);
			}

            
            
                //goes through students in used student list and sees if new student has already been created
                for (int i = ClassList.Count(); i > 0; i--)
                {
                    
                    //gets random number
                    int Student = GroupNumber.Next(1, ClassList.Count() + 1);
                    bool myBool = true;
                    
                    //checks to see if student number has already been used
                    if (AlreadyUsedNumbers.Contains(Student))
                    {
                        myBool = false;
                        i++;
                    }
                    else if (myBool)
                    {
                        
                        GroupList.Add(Student);
                        AlreadyUsedNumbers.Add(Student);
                        
                        if (GroupList.Count() == GroupSize)
	                                    {
                                            
                                            Console.WriteLine("Group " + WhatGroup);
                                            for (int x = 0; x < GroupSize ; x++)
                                            {
                                                Console.Write("#" + GroupList[x] + " ");
                                                
                                            }
                                            Console.WriteLine("\n");
                                            Console.WriteLine("------------------");
                                            GroupList.Clear();
                                            WhatGroup++;
			                            }
                        
                }
                
            }
        }
    }
}
