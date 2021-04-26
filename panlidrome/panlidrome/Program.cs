using System;

namespace panlidrome
{
    class Program
    {
        static void Main(string[] args)
        {

            //Method 1
            // Peusdocode, check if string is Panlidrome

            //Capture user input as string s, init empty string revs for reversing string later. 
            // we check from the back first, starting at s.Length-1, then add each of the char from the string index to revs+= and .ToString();
            // add conditional to check if the revs equals to s then print out else is not. 

            // Time complexity: O(NM) , Space Complexity: O(M)- wrong 

            // Time complexity: O(N)^2 , Space Complexity: O(N)^2 because strings are immutable, use StringBuilder, then O(N) for both

            //string s, revs = "";
            //Console.WriteLine(" Enter string");
            //s = Console.ReadLine().ToLower();

            //for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            //{
            //    revs += s[i].ToString();
            //}

            //if (revs == s) // Checking whether string is palindrome or not  
            //{
            //    Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            //}
            //else
            //{
            //    Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            //}
            //Console.ReadKey();



            Console.WriteLine(Pand("cac"));
            Console.WriteLine(Pand("cabbac"));
            
            //string s = "cabbaac";
            //have two pointer var, A at index 0 B at index lenght-1
            //loop through the array from 0 to len/2   
            //compare element at index A and B, if they are not the same, return false
            //if index of B == index of A, return true
            //for each step of the loop, increase index of A by 1 and decrease index of B by 1

            // int a = 0;
            // int b= 4;

                // c=c
                // a=1, b=3
                //a=a
                //a=2, b=2
                //a index = b index
                // O(N), Space = O(1) 

                //c=c
                //a=1, b=5
                //a=a
                //a=2, b=4
                //b!a
                //return false

            // if(arr[a]!=arr[b]){

            // return false}
            //else{
                
            //}

            //Method 2
            // Peusdocode, check if string is Panlidrome

            //Capture s string from user input
            // initialize a new char array and convert the string to an array of characters 
            // then reverse that array of chars with Array.Reverse()
            // now we will check compare the characters , revs will take in the reversed ch as a new string

            // init a boolean b and check if the original string s input .Equals to revs (reversed string) , StringComparison.OrdinalIgnoreCase
            // is to ignore upper/lower casing.

            // add conditionals true and false to print out Panlindrome or not Panlindrome

            // Time Complexity: O(NM) , Space Complexity: O(M) 

            //string s, revs = "";
            //Console.WriteLine(" Enter string");
            //s = Console.ReadLine();

            //char[] ch = s.ToCharArray();
            //Array.Reverse(ch);
            //revs = new string(ch);
            //bool b = s.Equals(revs, StringComparison.OrdinalIgnoreCase);
            //if (b == true)
            //{
            //    Console.WriteLine("" + s + " is a Palindrome!");
            //}
            //else
            //{
            //    Console.WriteLine(" " + s + " is not a Palindrome!");
            //}
            //Console.Read();
        }
        public static bool Pand(string strg)
        {
            int a = 0;
            int b = strg.Length - 1;

            for (int i = 0; i <= (strg.Length) / 2; i++)
            {
                if (strg[a] != strg[b])
                {
                    return false;
                }
 
                    a++;
                    b--;
            }
            return true;
        }
    }
}
