using System;
using System.Collections.Generic;

namespace HospitalStaff
{
    internal static class Program
    {
        static void Main()
        {
            List<IHospitalWorker> staff = new List<IHospitalWorker>
            {
                new Attending { Name = "Richard Srini", EmployeeID = "D94B72E", HireDate = "1996-02-02", Specialty = "Ophthalmology" },
                new Attending { Name = "Ulric Wong", EmployeeID = "9BFA2B8", HireDate = "1992-08-04", Specialty = "PreventiveMedicine" },
                new Attending { Name = "Jillian Duran", EmployeeID = "87EBCEC", HireDate = "2003-09-24", Specialty = "Pathology" },
                new Attending { Name = "Noelle Wu", EmployeeID = "6C8A46A", HireDate = "1999-12-26", Specialty = "NuclearMedicine" },
                new Attending { Name = "Macey Harris", EmployeeID = "37F895D", HireDate = "2013-06-08", Specialty = "EmergencyMedicine" },
                new Attending { Name = "Hope Welch", EmployeeID = "B239993", HireDate = "2002-07-23", Specialty = "EmergencyMedicine" },
                new Attending { Name = "Dale Pacheco", EmployeeID = "46A169E", HireDate = "1994-12-04", Specialty = "AllergyAndImmunology" },
                new Attending { Name = "Channing Sarıkaya", EmployeeID = "E3369C5", HireDate = "1992-07-13", Specialty = "InternalMedicine" },
                new Attending { Name = "Regina Peerenboom", EmployeeID = "3B79DBB", HireDate = "2012-10-04", Specialty = "EmergencyMedicine" },
                new Attending { Name = "Charde Ihemeje", EmployeeID = "39DDE44", HireDate = "2003-06-06", Specialty = "MedicalGenetics" }
            };

            foreach (IHospitalWorker worker in staff)
            {
                Console.WriteLine(
                    $"Name: {worker.Name}, ID: {worker.EmployeeID}, Hire Date: {worker.HireDate}"
                );
                if (worker is Attending attending)
                {
                    Console.WriteLine(
                        $"\tType: Attending, Residents: {attending.SupervisedResidentsCount}"
                    );
                }
            }

            Console.ReadKey(intercept: true);
        }
    }
}
