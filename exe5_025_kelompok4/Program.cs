using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5_025_kelompok4
{
    class Node
    {
        public string name;
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
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            nm = Console.ReadLine();
            newnode.name = nm;
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
