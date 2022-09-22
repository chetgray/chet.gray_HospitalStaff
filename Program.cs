using System;
using System.Collections.Generic;

namespace HospitalStaff
{
    internal static class Program
    {
        static void Main()
        {
            List<IHospitalWorker> staff = new List<IHospitalWorker>();

            foreach (IHospitalWorker worker in staff)
            {
                Console.WriteLine(
                    $"Name: {worker.Name}, ID: {worker.EmployeeID}, Hire Date: {worker.HireDate}"
                );
            }

            Console.ReadKey(intercept: true);
        }
    }
}
