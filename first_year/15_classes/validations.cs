using System;
using System.Net;

namespace validations
{
    class Functions
    {
        public static bool isAgeValid(string age)
        {
            int ageInt;
            bool result = false;
            try
            {
                ageInt = Convert.ToInt32(age);
                if (ageInt > 0 && ageInt < 120) result = true;
            }
            catch
            {
                // Nada para hacer...
            }
            return result;
        }
    }
}