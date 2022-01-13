using System;

namespace Strings_practice
{
    class Program
    {       

        //Program No : 1 Hello World 
        public static void HelloWorld()
        {
            string message = "Hello World!";
            Console.WriteLine(message[6]);
        }
        //Program No : 2 Calculate Length Of The String
        public static void CalculateLengthOfTheString()
        {
            string message = "Hello World!";

            int length = message.Length;

            Console.WriteLine(length);
        }

        //Program No : 3 Copy One String to Another String
        public static void CopyOneStringToAnotherString()
        {
            //Given String 
            string message = "Hello World!";
            //First Task : Convert it into Character 
            char[] A = message.ToCharArray();
            // Create a New Array 
            char[] B = new char[A.Length];
            // Copying All elements from Char Array A to Char Array B
            for(int i=0; i < A.Length;i ++)
            {
                B[i] = A[i];
            }
            //Printing All elements in Array B 
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i]);
            }
            
        }

        //Program No : 4 Reverse a String 
        public static void ReverseAString() {
            //Step :01 string is given
            string message = "Hello World";
            //Step 02: convert string into Char Array
            char[] A = message.ToCharArray();
            //Step 03: Defining a container Array
            Char[] B = new char[A.Length];

            //Proceessing 
            for(int i = 0, j=A.Length-1; i < A.Length && j >=0;i++ , j--)
            {
                B[j] = A[i];
            }
            //Printing All elements in Array B 
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i]);
            }


        }

        //Program No : 5 CheckPalindrome 
        public static void CheckPalindrome()
        {
            bool IsPalindrome = true;
            //Step :01 string is given
            string message = "AHHDDHHA";
          
            //Step 02: convert string into Char Array
            char[] A = message.ToCharArray();
            //Step 03: Defining a container Array
            Char[] B = new char[A.Length];

            //Proceessing 
            for (int i = 0, j = A.Length - 1; i < A.Length && j >= 0; i++, j--)
            {
                B[j] = A[i];
            }
            //Printing All elements in Array B 
            for (int i = 0, j = A.Length - 1; i < A.Length && j >= 0; i++, j--)
            {
                IsPalindrome = true;
                if(B[i] != A[i])
                {
                    IsPalindrome = false;
                    break;
                }
            }


            Console.Write(IsPalindrome);
        }
        //Program No : 6 CheckPalindrome with Spaces
        public static void CheckPalindromeWithSpaces()
        {
            bool IsPalindrome = true;
            //Step :01 string is given
            string message = "too hot to hoot";
            message= message.Replace(" ","");

            //Step 02: convert string into Char Array
            char[] A = message.ToCharArray();
            
            //Step 03: Defining a container Array
            Char[] B = new char[A.Length];

            //Proceessing 
            for (int i = 0, j = A.Length - 1; i < A.Length && j >= 0; i++, j--)
            {
                B[j] = A[i];
            }
            //Printing All elements in Array B 
            for (int i = 0, j = A.Length - 1; i < A.Length && j >= 0; i++, j--)
            {
                IsPalindrome = true;
                if (B[i] != A[i])
                {
                    IsPalindrome = false;
                    break;
                }
            }


            Console.Write(IsPalindrome);
        }
        static void Main(string[] args)
        {
            //Program No : 1 Hello World 
            // Program.HelloWorld();

            //Program No : 2 Calculate Length Of The String
            // CalculateLengthOfTheString();

            //Program No : 3 Copy One String to Another String
            // CopyOneStringToAnotherString();

            //Program No : 4 Reverse a String 
            // ReverseAString();

            //Program No : 5 CheckPalindrome 
            // CheckPalindrome();

            //Program No : 6 CheckPalindrome 
            CheckPalindromeWithSpaces();

            Console.ReadLine();
        }

    }
}
