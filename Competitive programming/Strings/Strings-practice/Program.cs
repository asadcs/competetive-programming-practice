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

        //Program No : 4(a) Reverse Characters in String 
        public static void ReverseCharInString() {
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

        //Program No : 4(b) Reverse Words in String 
        public static void ReverseWordsInString()
        {
            //Youtube Ref : https://www.youtube.com/watch?v=M-XYuPCTfgY
            //Step :01 string is given
            string message = ".I.LIKE...THIS.PROGRAM";
            string container = string.Empty;
           

            foreach(var substring in message.Split('.'))
            {
                container = substring + "." + container;
;           }

            container = container.Remove(container.Length - 1);

            Console.Write(container);
            
            //Algo:
            //Convert target string into char array ;
            //Declare an empty container string to hold the reverse order words
            //Idea is starting from end , one by one eleminating a word from string S1
            //using substring function . it requires two params 1. start index , length of the  
            //start a loop from the end to start
            //Define a variable that count the traversed chars till it finds a "."

            //Calculate the length of the targe array 
            //



        }

        //Program No : 4(C) Reverse Each Word in String 
        public static void ReverseEachWordsInString()
        {
            //Youtube Ref : https://www.youtube.com/watch?v=M-XYuPCTfgY
            //Step :01 string is given
            string message = ".I.LIKE...THIS.PROGRAM";
            string container = string.Empty;


            foreach (var substring in message.Split('.'))
            {
                container = substring + "." + container;
                ;
            }

            container = container.Remove(container.Length - 1);

            Console.Write(container);

            //Algo:
            //Convert target string into char array ;
            //Declare an empty container string to hold the reverse order words
            //Idea is starting from end , one by one eleminating a word from string S1
            //using substring function . it requires two params 1. start index , length of the  
            //start a loop from the end to start
            //Define a variable that count the traversed chars till it finds a "."

            //Calculate the length of the targe array 
            //



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

        //Program No : 7  Convert Lower To Upper
        public static void ConvertLowerToUpper()
        {
            string slogan= "pakistan zindabad";

            char[] A = slogan.ToCharArray();

            for(int i=0;i<slogan.Length;i++)
            {
                A[i] = Convert.ToChar(Convert.ToInt32(A[i]) - 32);
                Console.Write(A[i]);
            }


        }
        //Program No : 8  Convert Lower To Upper
        public static void ConvertFirstLetterLowerToUpper()
        {
            string slogan = "pakistan zindabad is the moto of life";

            char[] A = slogan.ToCharArray();

            for (int i = 0; i < slogan.Length; i++)
            {
                if(A[i]==' ')
                {
                    A[i+1] = Convert.ToChar(Convert.ToInt32(A[i+1]) - 32);
                   
                }
                Console.Write(A[i]);
            }


        }
        static void Main(string[] args)
        {
            //Program No : 1 Hello World 
            // Program.HelloWorld();

            //Program No : 2 Calculate Length Of The String
            // CalculateLengthOfTheString();

            //Program No : 3 Copy One String to Another String
            // CopyOneStringToAnotherString();

            //Program No : 4(a) Reverse Characters in String 
            //ReverseCharInString();

            //Program No : 4(b) Reverse Words in String 
            // ReverseWordsInString();

            //Program No : 5 CheckPalindrome 
            // CheckPalindrome();

            //Program No : 6 CheckPalindrome 
            // CheckPalindromeWithSpaces();

            //Program No : 7  Convert Lower To Upper
            //ConvertLowerToUpper();

            //Program No : 8  Convert Lower To Upper
            ConvertFirstLetterLowerToUpper();

            Console.ReadLine();
        }

    }
}
