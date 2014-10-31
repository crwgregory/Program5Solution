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
            groupMaker(20, 5);

            Console.ReadKey();
        }

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
                                                Console.WriteLine("# " + GroupList[x]);
                                            }
                                            GroupList.Clear();
                                            WhatGroup++;
			                            }
                        
                }
                
            }
        }
    }
}
