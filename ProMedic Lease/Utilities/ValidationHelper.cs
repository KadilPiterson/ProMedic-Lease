using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProMedic_Lease.Utilities
{
    public class ValidationHelper
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPesel(string pesel)
        {
            if (pesel.Length != 11 || !pesel.All(char.IsDigit))
            {
                return false;
            }

            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += weights[i] * int.Parse(pesel[i].ToString());
            }
            int lastDigit = int.Parse(pesel[10].ToString());
            sum %= 10;
            sum = 10 - sum;
            sum %= 10;

            return lastDigit == sum;
        }

        public static bool AreDatesValid(DateTime startDate, DateTime? endDate)
        {
            if (endDate.HasValue)
            {
                return startDate <= endDate.Value;
            }
            return true;
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) && phoneNumber.All(char.IsDigit) && phoneNumber.Length == 9;
        }

        public static bool IsValidPostalCode(string postalCode)
        {
            // Przykład walidacji polskiego kodu pocztowego: 00-000
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                return false;
            }

            Regex regex = new Regex(@"^\d{2}-\d{3}$");
            return regex.IsMatch(postalCode);
        }

        public static bool IsStringNotNullOrEmpty(string str)
        {
            return !string.IsNullOrEmpty(str);
        }
    }
}
