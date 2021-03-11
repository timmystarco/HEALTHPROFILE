using System;

namespace HEALTHPROFILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t HEALTH PROFILE APPLICATION \n");
            Console.WriteLine("\a");


            HealthProfile profile1 = new HealthProfile(null, null, null, null, 0, 0, 0, 0, 0);

            Console.WriteLine("Enter First Name:");
            profile1.FirstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Last Name:");
            profile1.LastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Gender: ");
            profile1.Gender = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Month of Birth:");
            profile1.MonthOfBirth = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Day of Birth:");
            profile1.DayOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year of Birth:");
            profile1.YearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height in inches:");
            profile1.HeightInInches = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Enter Weight in pounds:");
            profile1.WeightInPounds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Current Year:");
            profile1.CurrentYear = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n\nPATIENT RESULT");
            profile1.DisplayFirstName();
            profile1.DisplayLastName();
            profile1.DisplayGender();
            profile1.DisplayMonthOfBirth();
            profile1.DisplayDayOfBirth();
            profile1.DisplayYearOfBirth();
            profile1.DisplayHeightInInches();
            profile1.DisplayWeightInPounds();
            profile1.DisplayCurrentYear();
            profile1.DisplayPatientAge();
            profile1.DisplayMaximumHeartRate();
            profile1.DisplayMin_target_heart_rate();
            profile1.DisplayMax_target_heart_rate();
            profile1.DisplayBMI();
            profile1.DisplayBMIOutput();
            profile1.DisplayBMIChart();
        }
    }
}
