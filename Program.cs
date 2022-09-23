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
                new Attending { Name = "Yvette Iba", EmployeeID = "E3369C5", HireDate = "1992-07-13", Specialty = "InternalMedicine" },
                new Attending { Name = "Simon Bellamy", EmployeeID = "3B79DBB", HireDate = "2012-10-04", Specialty = "EmergencyMedicine" },
                new Attending { Name = "Charde Ihemeje", EmployeeID = "39DDE44", HireDate = "2003-06-06", Specialty = "MedicalGenetics" }
            };
            staff.Add(new Resident { Name = "Abra Mendoza", EmployeeID = "956B46B", HireDate = "2022-07-29", SupervisingAttending = (Attending)staff[0] });
            staff.Add(new Resident { Name = "Christian Inacio", EmployeeID = "8ADF7A7", HireDate = "2020-12-18", SupervisingAttending = (Attending)staff[1] });
            staff.Add(new Resident { Name = "Robert Karagöz", EmployeeID = "829777A", HireDate = "2022-05-04", SupervisingAttending = (Attending)staff[1] });
            staff.Add(new Resident { Name = "Gretchen Meyer", EmployeeID = "BB8DC6D", HireDate = "2021-02-10", SupervisingAttending = (Attending)staff[2] });
            staff.Add(new Resident { Name = "Keegan Lam", EmployeeID = "A535F16", HireDate = "2021-09-15", SupervisingAttending = (Attending)staff[3] });
            staff.Add(new Resident { Name = "Illana Özçelik", EmployeeID = "2EC64A7", HireDate = "2020-07-22", SupervisingAttending = (Attending)staff[5] });
            staff.Add(new Resident { Name = "Chaim Hill", EmployeeID = "5A3C5B5", HireDate = "2022-08-17", SupervisingAttending = (Attending)staff[8] });
            staff.Add(new Resident { Name = "Giacomo Steiner", EmployeeID = "508E28B", HireDate = "2022-09-12", SupervisingAttending = (Attending)staff[3] });
            staff.Add(new Resident { Name = "Ezra Boer", EmployeeID = "533A9AE", HireDate = "2021-04-06", SupervisingAttending = (Attending)staff[1] });
            staff.Add(new Resident { Name = "Asher Little", EmployeeID = "139AF44", HireDate = "2021-09-13", SupervisingAttending = (Attending)staff[4] });

            foreach (IHospitalWorker worker in staff)
            {
                Console.Write(
                    $"Name: {worker.Name},\tID: {worker.EmployeeID},  Hire Date: {worker.HireDate}"
                );
                if (worker is Attending attending)
                {
                    Console.Write(
                        $"  Type: Attending,\tResidents: {attending.SupervisedResidentsCount}"
                    );
                }
                if (worker is Resident resident)
                {
                    Console.Write(
                        $"  Type: Resident,\tAttending: {resident.SupervisingAttending.Name}"
                    );
                }
                Console.WriteLine();
            }

            Console.ReadKey(intercept: true);
        }
    }
}
