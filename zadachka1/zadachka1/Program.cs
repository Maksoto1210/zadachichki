using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachka1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DoublyLinkedList list=new DoublyLinkedList(); ;
            list.AddToFront(10);
            list.AddToFront(20);
            list.AddToFront(30);
            list.AddToFront(40);

            Console.WriteLine("Original list: ");
            list.PrintList();

            list.Reverse();

            Console.WriteLine("Reversed list: ");
            list.PrintList();

        }
    }
}
