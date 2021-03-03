using System;

namespace EmployeeAttendance
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int salary = 0;    
            Random random = new Random();

            for (int day = 0; day <= NUMBER_OF_WORKING_DAYS; day++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                salary = salary + empWage;
            }
            Console.WriteLine("Salary for Month :" + salary);
        }
    }
}
