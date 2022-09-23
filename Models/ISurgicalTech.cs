namespace HospitalStaff.Models
{
    internal interface ISurgicalTech : IHospitalWorker
    {
        string Department { get; set; }
    }
}