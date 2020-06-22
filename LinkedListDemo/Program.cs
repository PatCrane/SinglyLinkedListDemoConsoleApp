using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create instance of new Singly Linked List

            SinglyLinkedList mySinglyLinkedList = new SinglyLinkedList();

            //Pass in some values

            mySinglyLinkedList.InsertFirst(100);
            mySinglyLinkedList.InsertFirst(50);
            mySinglyLinkedList.InsertFirst(99);
            mySinglyLinkedList.InsertFirst(88);
            //Insert number at the end of the list
            mySinglyLinkedList.InsertLast(999000);
            //Display the list
            mySinglyLinkedList.DisplayList();
            //Remove the first node
            mySinglyLinkedList.DeleteFirst();
            //Display the list again
            mySinglyLinkedList.DisplayList();


            Console.ReadLine();
        }
    }

    public class SinglyLinkedList
    {
        private Node First;

        //Is the node empty?
        public bool IsTheNodeEmpty()
        {
            return (First == null);
        }

        //Insert the first node into the list
        public void InsertFirst(int data)
        {
            Node firstNode = new Node(); //Make an instance the first node

            firstNode.Data = data; //Set the data of the node to the data passed in

            firstNode.Next = First; // The first node in the list points to iteself

            First = firstNode;
        }

        //Delete the first node in the list
        public Node DeleteFirst()
        {
            Node output = First;

            First = First.Next;

            return output;
        }

        //Print out the contents of the list
        public void DisplayList()
        {
            Console.WriteLine("List (first -- last) ");
            
            Node current = First;

            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
            Console.WriteLine();
        }

        //Insert the last node
        public void InsertLast(int data)
        {
            Node current = First;

            while (current.Next != null)
            {
                current = current.Next;
            }

            Node newNode = new Node();

            newNode.Data = data;

            current.Next = newNode;
        }
    }
    
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; } // Points to the next node

        public void DisplayNode()
        {
            string output = $"< {Data} >";

            Console.WriteLine(output);
        }
    }
}
