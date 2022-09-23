namespace HospitalStaff.Models
{
    internal interface IHospitalWorker
    {
        string Name { get; set; }
        string EmployeeID { get; set; }
        string HireDate { get; set; }
    }
}
