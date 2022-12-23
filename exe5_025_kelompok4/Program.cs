using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exe5_025_kelompok4
{
    class Node
    {
        public string val;
        public Node next;
    }
    class queue
    {
        Node reza, risaldi;
        public queue()
        {
            reza = null;
            risaldi = null;
        }

        public void insert()
        {
            string data;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            data = Console.ReadLine();
            newnode.val = data;
            newnode.next = null;
            if(reza == null)
            {
                reza = newnode;
                risaldi = newnode;
                return;
            }
            risaldi.next = newnode;
            risaldi = newnode;
        }
        public void delete()
        {
            if(reza == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            reza = reza.next;
            if (reza == null)
                risaldi = null;
        }
        public void display()
        {
            if(reza == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node display;
            int Count = 1;
            for (display = reza; display != null; display = display.next)
                Console.WriteLine("Data Number ["+ (Count++)+ "] is :" + display.val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement Insert Operation");
                    Console.WriteLine("2. Implement Delete Operation");
                    Console.WriteLine("3. Display Values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch(ch)
                    {
                        case '1':
                            q.insert();
                            break;
                        case '2':
                            q.delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the value entered. ");
                }
            }
        }
    }
}
