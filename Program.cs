using System;
using System.Collections.Generic;

namespace HospitalStaff
{
    internal static class Program
    {
        static void Main()
        {
            List<IHospitalWorker> staff = new List<IHospitalWorker>();

            staff.Add(new Attending { Name = "Richard Srini", EmployeeID = "D94B72E", HireDate = "1996-02-02", Specialty = "Ophthalmology" });
            staff.Add(new Attending { Name = "Ulric Wong", EmployeeID = "9BFA2B8", HireDate = "1992-08-04", Specialty = "PreventiveMedicine" });
            staff.Add(new Attending { Name = "Jillian Duran", EmployeeID = "87EBCEC", HireDate = "2003-09-24", Specialty = "Pathology" });
            staff.Add(new Attending { Name = "Noelle Wu", EmployeeID = "6C8A46A", HireDate = "1999-12-26", Specialty = "NuclearMedicine" });
            staff.Add(new Attending { Name = "Macey Harris", EmployeeID = "37F895D", HireDate = "2013-06-08", Specialty = "EmergencyMedicine" });
            staff.Add(new Attending { Name = "Hope Welch", EmployeeID = "B239993", HireDate = "2002-07-23", Specialty = "EmergencyMedicine" });
            staff.Add(new Attending { Name = "Dale Pacheco", EmployeeID = "46A169E", HireDate = "1994-12-04", Specialty = "AllergyAndImmunology" });
            staff.Add(new Attending { Name = "Yvette Iba", EmployeeID = "E3369C5", HireDate = "1992-07-13", Specialty = "InternalMedicine" });
            staff.Add(new Attending { Name = "Simon Bellamy", EmployeeID = "3B79DBB", HireDate = "2012-10-04", Specialty = "EmergencyMedicine" });
            staff.Add(new Attending { Name = "Charde Ihemeje", EmployeeID = "39DDE44", HireDate = "2003-06-06", Specialty = "MedicalGenetics" });

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

            staff.Add(new NurseSupervisor { Name = "Audrey Moore", EmployeeID = "938C4A2", HireDate = "2005-06-24" });
            staff.Add(new NurseSupervisor { Name = "Teegan İlhan", EmployeeID = "601611B", HireDate = "2005-08-09" });
            staff.Add(new NurseSupervisor { Name = "Avram Chng", EmployeeID = "77B8691", HireDate = "2009-08-21" });
            staff.Add(new NurseSupervisor { Name = "Garth Zhuo", EmployeeID = "8165B5D", HireDate = "2014-09-18" });
            staff.Add(new NurseSupervisor { Name = "Quinn Franco", EmployeeID = "68B5EA9", HireDate = "2005-02-22" });
            staff.Add(new NurseSupervisor { Name = "Aidan Cortes", EmployeeID = "BDD98F7", HireDate = "2008-12-01" });
            staff.Add(new NurseSupervisor { Name = "Abra Meena", EmployeeID = "8B151D8", HireDate = "2005-07-25" });
            staff.Add(new NurseSupervisor { Name = "Forrest Schuster", EmployeeID = "BD9DDE8", HireDate = "2018-01-17" });
            staff.Add(new NurseSupervisor { Name = "Destiny Fonseca", EmployeeID = "91407D8", HireDate = "2021-01-10" });
            staff.Add(new NurseSupervisor { Name = "Grant Dutta", EmployeeID = "3EA1784", HireDate = "2004-08-30" });

            staff.Add(new RegisteredNurse { Name = "Rhona Atmaca", EmployeeID = "7345DB7", HireDate = "2022-05-27", SupervisingNurseSupervisor = (NurseSupervisor)staff[21] });
            staff.Add(new RegisteredNurse { Name = "Tanisha de Waal", EmployeeID = "5D377F3", HireDate = "2022-03-03", SupervisingNurseSupervisor = (NurseSupervisor)staff[23] });
            staff.Add(new RegisteredNurse { Name = "Kennedy Schmitt", EmployeeID = "3CEA275", HireDate = "2022-05-26", SupervisingNurseSupervisor = (NurseSupervisor)staff[26] });
            staff.Add(new RegisteredNurse { Name = "Dante Maler", EmployeeID = "CD32520", HireDate = "2022-03-04", SupervisingNurseSupervisor = (NurseSupervisor)staff[21] });
            staff.Add(new RegisteredNurse { Name = "Walter Gün", EmployeeID = "A681425", HireDate = "2022-03-21", SupervisingNurseSupervisor = (NurseSupervisor)staff[29] });
            staff.Add(new RegisteredNurse { Name = "Slade de Azevedo", EmployeeID = "2B68B85", HireDate = "2021-12-13", SupervisingNurseSupervisor = (NurseSupervisor)staff[22] });
            staff.Add(new RegisteredNurse { Name = "Clarke Biçer", EmployeeID = "C5CAF5B", HireDate = "2021-11-02", SupervisingNurseSupervisor = (NurseSupervisor)staff[23] });
            staff.Add(new RegisteredNurse { Name = "Riley van Gelder", EmployeeID = "E7BF304", HireDate = "2022-07-20", SupervisingNurseSupervisor = (NurseSupervisor)staff[27] });
            staff.Add(new RegisteredNurse { Name = "Lois Green", EmployeeID = "5E9796C", HireDate = "2022-08-30", SupervisingNurseSupervisor = (NurseSupervisor)staff[22] });
            staff.Add(new RegisteredNurse { Name = "Price Aras", EmployeeID = "277AF98", HireDate = "2022-07-21", SupervisingNurseSupervisor = (NurseSupervisor)staff[21] });

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
                if (worker is NurseSupervisor nurseSupervisor)
                {
                    Console.Write(
                        $"  Type: Nurse Supervisor,\tNurses: {nurseSupervisor.SupervisedNursesCount}"
                    );
                }
                if (worker is RegisteredNurse registeredNurse)
                {
                    Console.Write(
                        $"  Type: Registered Nurse,\tSupervisor: {registeredNurse.SupervisingNurseSupervisor.Name}"
                    );
                }
                Console.WriteLine();
            }

            Console.ReadKey(intercept: true);
        }
    }
}
