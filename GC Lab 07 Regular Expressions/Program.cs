using System;
using System.Text.RegularExpressions;

namespace GC_Lab_07_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetName("Please enter your first and last name: ");
            string email = GetEmail("Please enter your email address: ");
            string phone = GetPhone("Please enter your full phone number: ");
            string bDay = GetBirthDate("Please enter your birthday in dd/mm/yyyy format: ");

            Console.WriteLine($"Here is what you entered. Name: {name}, email: {email}, phone: {phone}, birthday: {bDay}");
        }

        public static string GetName(string prompt)
        {
            while(true)
            {
                Console.WriteLine(prompt);
                string userName = Console.ReadLine();
                if(NameValid(userName))
                    return userName;
            }
        
        }
        public static string GetEmail(string prompt)
        {
            while(true)
            {
                Console.WriteLine(prompt);
                string userEmail = Console.ReadLine();
                if(EmailValid(userEmail))
                    return userEmail;
            }
        
        }
        public static string GetPhone(string prompt)
        {
            while(true)
            {
                Console.WriteLine(prompt);
                string userPhone = Console.ReadLine();
                if(PhoneValid(userPhone))
                    return userPhone;
            }
        
        }
        public static string GetBirthDate(string prompt)
        {
            while(true)
            {
                Console.WriteLine(prompt);
                string userBirthday = Console.ReadLine();
                if(BDValid(userBirthday))
                    return userBirthday;
            }
        
        }
        
        public static bool NameValid(string name)
        {
            if (Regex.IsMatch(name, @"\b[A-Z][a-z]{1,29}\s[A-Z][a-z]{1,29}\b"))
                return true;
            else
                return false;
        }

        public static bool EmailValid(string email)
        {
            if (Regex.IsMatch(email, @"\w{5,10}\@\w{5,10}\.\w{2,3}"))
                return true;
            else
                return false;
        }
        
        public static bool PhoneValid(string phone)
        {
            if (Regex.IsMatch(phone, @"\b\d{3}-\d{3}-\d{4}\b"))
                return true;
            else
                return false;
        }

        public static bool BDValid(string birthday)
        {
            if (Regex.IsMatch(birthday, @"\b\d{2}\/\d{2}\/\d{4}\b"))
                return true;
            else
                return false;
        }

    }

}
