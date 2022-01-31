/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}",final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[]{"Marshall", "Student","Center"};
            string[] bulls_string2 = new string[]{"MarshallStudent", "Center"};
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch ='c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            String fnl = "";


            Char[] vw = new Char[5] { 'A', 'E', 'I', 'O', 'U' }; // declaring vowels
            int vw_flag;

            try
            {
                // write your code here


                for (int i = 0; i < s.Length; i++) // first loop i
                {
                    vw_flag = 0;
                    char letter = char.ToUpper(s[i]);

                    for (int j = 0; j < vw.Length; j++) // checking fot conditions
                    {
                        if (letter == vw[j])
                        {
                            vw_flag = 1;
                        }
                    }


                    if (vw_flag == 0)
                    {
                        fnl += letter;
                    }
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return fnl;

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            
            bool similar = false;

            string mystr1 = ""; // declaring string 1
            string mystr2 = ""; // declaring string 2

            try
            {
                // write your code here.


                mystr1 = String.Join("", bulls_string1).ToUpper(); // Computing the strings
                mystr2 = String.Join("", bulls_string2).ToUpper();

                Console.WriteLine(mystr1 + " : " + mystr2); 

                if (mystr1 == mystr2) // checking similar elements
                {
                    similar = true;
                }

                return similar;
            }


            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // write your code here
                int sumOfArray = 0, count_uniq= 0; 
                
                // Hash to store all element of array
                //HashSet<int> s = new HashSet<int>();
                for (int i = 0; i < bull_bucks.Length; i++) // First Loop i
                {
                    for (int j = 0; j < bull_bucks.Length; j++) // Second loop j
                    {
                        if (bull_bucks[i] == bull_bucks[j])
                        {
                            count_uniq++;
                        }

                    }

                    if (count_uniq == 1) // unique element of array
                    {
                        sumOfArray += bull_bucks[i]; // adding unique element of array
                    }
                    count_uniq = 0; 

                }
                
                return sumOfArray; //

            }

            catch (Exception)
            {
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            int diaSum = 0, mid;
            try
            {
                // write your code here.
                
                int n = Convert.ToInt32(Math.Sqrt(bulls_grid.Length)); // Getting length of the matrix.

                for (int i = 0; i < n; i++) // sum of diagonals
                {
                    diaSum = diaSum + bulls_grid[i, i];
                }



                for (int i = n - 1; i >= 0; i--)
                {
                    diaSum = diaSum + bulls_grid[Math.Abs(n - (i + 1)), i];
                }
                if (((n) % 2 != 0) && (n > 1))
                {
                    
                    mid = (n - 1) / 2; // subtracting the middle value of matrix 
                    diaSum = diaSum - bulls_grid[mid, mid];
                }


                return diaSum;
            }

            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }


        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                int str_Length = bulls_string.Length; // Taking the length of string
                int ind_Length = indices.Length; // Taking the indices length

                if (str_Length == ind_Length && str_Length >= 1 && str_Length <= 100) //Computing for string 
                {


                    var rgexp = new Regex("^[a-z]+$");
                    if (rgexp.IsMatch(bulls_string) == true) 
                    {

                        string[] output = new string[str_Length];
                        for (int i = 0; i < str_Length; i++)
                        {
                            int val = indices[i];
                            if (val >= 0 && val < ind_Length)
                            {
                                output[val] = char.ToString(bulls_string[i]);
                            }
                            else
                            {
                                return null;
                            }
                        }

                        string s1 = string.Join("", output);
                        return s1;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String pre_str = "";
                int index = bulls_string6.IndexOf(ch); // declaring the string

                var exp = new Regex("^[a-z]+$");

                if (bulls_string6.Length >= 1 && bulls_string6.Length <= 250 && exp.IsMatch(char.ToString(ch)) == true)
                {

                    if (index >= 0)
                    {

                        string[] s1 = new string[bulls_string6.Length]; // declaring string length
                        int j = 0;
                        for (int i = index; i >= 0; i--) // first loop i
                        {
                            s1[j] = char.ToString(bulls_string6[i]);
                            j++;
                        }
                        s1[j] = bulls_string6.Substring(j, bulls_string6.Length - j);
                        string op = string.Join("", s1); // joing the string
                        return op;
                    }


                    else
                    {
                        return bulls_string6;
                    }
                }

                else
                {
                    return pre_str;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
