using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeselValidation
{
    public class PESELValidator
    {
        int[] pesel;

        public PESELValidator() { }

        public PESELValidator(string pesel)
        {
            this.LoadPesel(pesel);
        }

        public void LoadPesel(string pesel)
        {
            this.pesel = pesel.Select(o => Convert.ToInt32(o) - '0').ToArray();
        }

        public int CheckSum()
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                sum = sum + pesel[i] * weights[i];
            }
            sum %= 10;
            sum = 10 - sum;
            sum %= 10;

            Console.WriteLine("The checksum is: " + sum);
            return sum;
        }

        public String BirthDate()
        {
            int year = pesel[0] * 10 + pesel[1];
            int month = pesel[2] * 10 + pesel[3];
            int day = pesel[4] * 10 + pesel[5];
            if (month > 80 && month < 93)
            {
                year += 1800;
                month -= 80;
            }
            else if (month > 0 && month < 13)
            {
                year += 1900;
            }
            else if (month > 20 && month < 33)
            {
                year += 2000;
                month -= 20;
            }
            else
            {
                year = 1;
                month = 01;
                day = 01;
            }
            Console.WriteLine("Date of birth: " + day + "." + month + "." + year);
            return day + "." + month + "." + year;
        }

        public String Gender()
        {
            int[] male = { 1, 3, 5, 7, 9 };
            if (pesel[9] == male[0] || pesel[9] == male[1] || pesel[9] == male[2] || pesel[9] == male[3] || pesel[9] == male[4])
            {
                Console.WriteLine("Your gender is: male.");
                return "Male";
            }
            else Console.WriteLine("Your gender is: female.");

            return "Female";
        }

        public Boolean CheckPesel()
        {
            if (pesel == null)
            {
                Console.WriteLine("The PESEL number has not been entered!");
                return false;
            }
            else if (pesel.Length < 11 || pesel.Length > 11)
            {
                Console.WriteLine("Incorrect PESEL number!");
                return false;
            }
            else Console.WriteLine("The personal identification number has been entered correctly!");
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter new PESEL: ");
            PESELValidator PESEL = new PESELValidator(Console.ReadLine());
            PESEL.CheckSum();
            PESEL.BirthDate();
            PESEL.Gender();
            PESEL.CheckPesel();
            Console.ReadKey();
        }
    }
}

