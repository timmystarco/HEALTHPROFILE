using System;
using System.Collections.Generic;
using System.Text;

namespace HEALTHPROFILE
{
    public class HealthProfile
    {
        private string firstName;
        private string lastName;
        private string gender;
        private string monthOfBirth;
        private int dayOfBirth;
        private int yearOfBirth;
        private int heightInInches;
        private int weightInPounds;
        public int currentYear;

        public HealthProfile(string first, string last, string gen, string mob, int dob, int yob, int hgt, int wgt, int cy)
        {
            firstName = first;
            lastName = last;
            gender = gen;
            monthOfBirth = mob;
            dayOfBirth = dob;
            yearOfBirth = yob;
            heightInInches = hgt;
            weightInPounds = wgt;
            currentYear = cy;
        }

        //Properties for Instance Variables
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender=value;
            }
        }
        public string MonthOfBirth
        {
            get
            {
                return monthOfBirth;
            }
            set
            {
                monthOfBirth = value;
            }
        }
        public int DayOfBirth
        {
            get
            {
                return dayOfBirth;
            }
            set
            {
                dayOfBirth = value;
            }
        }
        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                yearOfBirth = value;
            }
        }
        public int HeightInInches
        {
            get
            {
                return heightInInches;
            }
            set
            {
                heightInInches = value;
            }
        }
        public int WeightInPounds
        {
            get
            {
                return weightInPounds;
            }
            set
            {
                weightInPounds = value;
            }
        }
        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
               currentYear = value;
            }
        }

        //METHODS

        //To calculate Patient Age
        public int PatientAge()
        {
            return CurrentYear - YearOfBirth; 
        }
        
        //To calculte the Maximum heart rate
        public int MaximumHeartRate()
        {
            return 220 - PatientAge();
        }

        // To calculate minimum target hearth rate  50% to 85% using 50% as maximum
        public double Min_target_heart_rate()
        {
            return MaximumHeartRate() * .5 ;
        }

        //To calculate Maximum target hearth rate 50% to 85% using 85% as maximum
        public double Max_target_heart_rate()
        {
            return MaximumHeartRate() * .85;
        }
        public float BMI()
        {
            return (WeightInPounds * 703) / (HeightInInches * HeightInInches);
        }

       
        //TO DISPLAY FOR EACH FIELD FOR OBJECT TO BE CREATED

        
        public void DisplayFirstName()
        {
            Console.WriteLine("\nFirst Name: {0}\t\t\t", FirstName);
        }

        public void DisplayLastName()
        {
            Console.WriteLine("Last  Name: {0} \t\t\t", LastName);
        }

        public void DisplayGender()
        {
            Console.WriteLine("Gender is : {0}\t\t\t", Gender);
        }

        public void DisplayMonthOfBirth()
        {
            Console.WriteLine("Month of birth: {0}\t\t", MonthOfBirth);
        }


        public void DisplayDayOfBirth()
        {
            Console.WriteLine("Day of birth  : {0}\t\t", DayOfBirth);
        }

        public void DisplayYearOfBirth()
        {
            Console.WriteLine("Year of birth : {0}\t\t", YearOfBirth);
        }

        public void DisplayHeightInInches()
        {
            Console.WriteLine("Height in inches: {0}\t", HeightInInches);
        }

        public void DisplayWeightInPounds()
        {
            Console.WriteLine("Weight in pounds: {0}\t", HeightInInches);
        }

        public void DisplayCurrentYear()
        {
            Console.WriteLine("Current year is : {0}\t", CurrentYear);
        }

      
        //TO DISPLAY FOR EACH METHOD FOR OBJECT TO BE CREATED
        
        public void DisplayPatientAge()
        {
            Console.WriteLine("Patient age is  : {0}\t", PatientAge());
        }

        public void DisplayMaximumHeartRate()
        {
            Console.WriteLine("Maximum heart rate is  : {0}\t", MaximumHeartRate());
        }

        public void DisplayMin_target_heart_rate()
        {
            Console.WriteLine("Minimum target heart rate is : {0}\t", Min_target_heart_rate());
        }

        public void DisplayMax_target_heart_rate()
        {
            Console.WriteLine("Maximum target heart rate is  : {0} \t", Max_target_heart_rate());
        }
        
        public void DisplayBMI()
        {
            Console.WriteLine("Body Mass Index : {0} \t", BMI());
        }

        public void DisplayBMIOutput()
        {
            if (BMI() < 18.5)
            {
                Console.WriteLine("\n You are Underweight. \n");
            }

            else if (BMI() < 25)
            {
                Console.WriteLine("\nYour weight is Normal.\n");
            }
            else if (BMI() < 30)
            {
                Console.WriteLine("\nYou are Overweight.\n");
            }

            else
                Console.WriteLine("\nYou are Obese.\n");
        }

        public void DisplayBMIChart()
        {
            Console.WriteLine("\n\n BMI VALUE \n\n Underweight:  Less than 18.5 \n Normal: Between 18.5 and 24.9 \n OverWeight: Between 25 and 29.9 \n Obese: 30 or greater\n");
        }




        public override string ToString()
        {
            return ("HEALTHPROFILE FOR " + FirstName + " "+ LastName + " \nGender \t\t" + Gender + "\n MonthOfBirth \t\t"
                + MonthOfBirth + "Day of Birth \t\t" + DayOfBirth + "YearOfBirth \t\t" + YearOfBirth + "\nHeightInInches:\t\t " 
                +HeightInInches + "\nWeightInPounds\t\t" + WeightInPounds + "\nCurrentYear\t\t" 
                +CurrentYear + "\nMaximum Hearth Rate" + MaximumHeartRate().ToString("F2") + "\n\n TARGET HEART RATE \nMinimum"
                +Min_target_heart_rate().ToString("F2") + "\n Maximum \t\t " + Max_target_heart_rate().ToString("F2") 
                + "\n BMI \t\t " + BMI().ToString() );
        }
    }   
        
}
