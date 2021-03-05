using System;

namespace EmployeeAttendance
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;

        public static int ComputeEmpWage()
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
                Console.WriteLine("Day: " + numOfWorkinDays + "Employee Hours : " + empHrs );
            }
            salary = numOfWorkingHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Salary of Month : " + salary);
            return salary;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}
