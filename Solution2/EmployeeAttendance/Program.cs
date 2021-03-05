using System;

namespace EmployeeAttendance
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int ComputeEmpWage(string Company , int EMP_RATE_PER_HOUR , int MAX_WORKING_DAYS , int MAX_WORKING_HOURS)
        {
            //Variables
            int empHrs = 0;
            int salary = 0;
            int numOfWorkinDays = 0;
            int numOfWorkingHours = 0;
            Random random = new Random();

            while (numOfWorkingHours <= MAX_WORKING_HOURS & numOfWorkinDays < MAX_WORKING_DAYS)
            {
                numOfWorkinDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                numOfWorkingHours += empHrs;
                Console.WriteLine("Day: " + numOfWorkinDays + "Employee Hours : " + empHrs);
            }
            salary = numOfWorkingHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage for Company : " + Company + " is : " + salary);
            return salary;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("Dmart",20, 2 ,10);
            ComputeEmpWage("Reliance", 10 , 4, 20 );


        }
    }
}
