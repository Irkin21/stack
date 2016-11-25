using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int top = -1;
          
       string s;
            int newmember = 0;
            int[] array = new int[10];
            /*     do
                 {
                     s = Convert.ToString(Console.ReadLine());
                     if (s != "x")
                     {
                         array[i] = Convert.ToInt32(s);
                         top++;
                     }

                 }
                 while (i > 10 || s != "x");
                 s = Convert.ToString(Console.ReadLine());*/
            do
            {
                Console.WriteLine("Press 'a' to push number ");
                Console.WriteLine("Press 'b' to pop number ");
                Console.WriteLine("Press 'c' to verify if stack is empty ");
                Console.WriteLine("Press 'd' to verify if stack is full ");
                Console.WriteLine("Press 'i' to view all elements ");
                Console.WriteLine("Press 'x' for exit ");
                s = Convert.ToString(Console.ReadLine());
                switch (s)
                {
                    case "a":
                        {
                            if (isFull(top, 10) != 0)
                            {
                                newmember = Convert.ToInt32(Console.ReadLine());
                                top = Push(top, newmember, array);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Stack is full");
                                break;
                            }
                        }
                    case "b":
                        {
                            if (IsEmpty(top) != 0)
                            {
                                Console.WriteLine("Stack is empty");
                                break;
                               

                            }
                            else
                            {
                                top = Pop(top, array[top], array);
                                break;


                            }
                          //  break;
                        }
                    case "c":

                        if (IsEmpty(top) == 0)
                        {
                            Console.WriteLine("Stack has elements");
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Stack is empty");
                            break;
                        }
                        //break;

                    case "d":

                        if (isFull(top, 10) != 0)
                        {
                            Console.WriteLine("Stack is not full");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Stack is full");
                            break;
                        }

                    case "i":
                        Peek(top, array);
                        break;
                }
            }
            while (s != "x");

            }

        static int Push(int top, int number,params int[] arr)
        {
            arr[top + 1] = number;
            top = top + 1;
            return top;
        }
        static int Pop(int top, int number, params int[] arr)
        {
            Console.WriteLine("Following ellement was deleted from stack");
            Console.WriteLine(arr[top]);
            arr[top] = 0;
            top = top - 1;
            return top;
        }
        static int IsEmpty(int top)
        {
            if (top < 0)
            {
                return 1;
            }
            else return 0;

        }
        static int isFull (int top, int max)
        {
            if (top+1 < max)
                return 1;
            else return 0;
        }
        static void Peek (int top, params int []arr)
        {
            for (int i=top;i>=0;i--)
            {
                Console.WriteLine("Steck elements:");
                Console.WriteLine(arr[i]);
            }
        }
    }
}
