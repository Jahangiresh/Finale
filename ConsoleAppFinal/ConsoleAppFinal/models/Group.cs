
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFinal
{
    class Group
    {
        public string No;
        public Category Category;
        public bool IsOnline;
        public List<Student> Students=new List<Student>();
        public int Limit;

    
        public Group(Category category, string no, bool isOnline)
        {
            No = no;
            List<Student> Students = new List<Student>();
            switch (category)
            {
                case Category.Programming:
                    Console.WriteLine("you chose programming");
                    break;
                case Category.Design:
                    Console.WriteLine("you chose design");

                    break;
                case Category.System_Administration:
                    Console.WriteLine("you chose system");

                    break;
                default:
                    break;

            }
            Category = category;
            IsOnline = isOnline;





        }
        public override string ToString()
        {
            string status = IsOnline ? "online qrup" : "offline qrup"; 
            return $"no:{No}, Category:{Category}, Status: {status}";
        }
    }

}