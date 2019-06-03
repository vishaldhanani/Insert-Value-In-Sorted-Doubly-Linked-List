using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertValueInSortedDoublyLinkedList
{
    class Program
    {
        // Node of a doubly linked list  
        public class Node
        {
            public int data;
            public Node next, prev;
        }

        class GFG
        {

            // function to create and return a new node  
            // of a doubly linked list  
            static Node getNode(int data)
            {
                // allocate node  
                Node newNode = new Node();

                // put in the data  
                newNode.data = data;
                newNode.prev = newNode.next = null;
                return newNode;

            }

            // function to insert a new node in sorted way in  
            // a sorted doubly linked list  
            static Node sortedInsert(Node head, Node newNode)
            {
                //Node current;

                // if list is empty  
                if (head == null)
                    head = newNode;

                // if the node is to be inserted at the beginning  
                // of the doubly linked list  
                else if (head.data >= newNode.data)
                {
                    newNode.next = head;
                    newNode.next.prev = newNode;
                    head = newNode;
                }

                else
                {
                   // current = head;

                    // locate the node after which the new node  
                    // is to be inserted  
                    while (head.next != null && head.next.data < newNode.data)
                    {
                        head = head.next;
                    }

                    /* Make the appropriate links */
                    newNode.next = head.next;

                    // if the new node is not inserted  
                    // at the end of the list  
                    if (head.next != null)
                    {
                        newNode.next.prev = newNode;
                    }
                    head.next = newNode;
                    newNode.prev = head;
                }
                return head;
            }

            // function to print the doubly linked list  
            static void printList(Node head)
            {
                while (head != null)
                {
                    Console.Write(head.data + " ");
                    head = head.next;
                }

            }

            // Driver code  
            public static void Main(String[] args)
            {
                /* start with the empty doubly linked list */
                Node head = null;

                // insert the following nodes in sorted way  
                Node new_node = getNode(8);
                head = sortedInsert(head, new_node);
                new_node = getNode(5);
                head = sortedInsert(head, new_node);
                new_node = getNode(3);
                head = sortedInsert(head, new_node);
                new_node = getNode(10);
                head = sortedInsert(head, new_node);
                new_node = getNode(12);
                head = sortedInsert(head, new_node);
                new_node = getNode(9);
                head = sortedInsert(head, new_node);

                Console.WriteLine("Created Doubly Linked List");
                printList(head);
            }
        }

    }
}
