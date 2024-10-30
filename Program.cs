using System;
using System.Transactions;

namespace Paired_Arrays_By_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Everything in "//" or "/**/" are comments or instructions
            /*
           
            Create 3 arrays that will hold 5 User's credentials:
            • Email
            • Username
            • Password

            For Example: email[0], username[0] and password[0] -> should belong to the same user.

            --------------------

            We will output the user's credentials by letting the user input an index

            SAMPLE OUTOUT:

            Index: 0 
            Email tutorialto@gmail.com
            Username:TutorialTo
            Password: tutorialto123

            */


            // This is where the code starts

            // This is your data
            string[] emails = { "Jeylo@gmail.com" /* Index 0 */,
                                "namemo@gmail.com" /* Index 1 */,
                                "nameniya@gmail.com" /* Index 2 */};

            string[] usernames = { "Jeylo" /* Index 0 */,
                                   "Name Mo" /* Index 1 */,
                                   "name Niya" /* Index 2 */};

            string[] passwords = { "Password Ko To" /* Index 0 */,
                                  "Password Mo To" /* Index 1 */,
                                  "Password Niya To" /* Index 2 */};


            // Choose what index to show we have 3 index so we should always start from 0
            Console.Write("Enter Index: ");
            int index = Convert.ToInt32(Console.ReadLine());


            // This is your output
            Console.WriteLine("Email    :" + emails[index]);
            Console.WriteLine("Username :" + usernames[index]);
            Console.WriteLine("Password :" + passwords[index]);

            // Always add this line to any of your codes
            Console.ReadLine();
        }
    }
}
