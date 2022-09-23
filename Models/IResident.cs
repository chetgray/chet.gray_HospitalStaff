namespace HospitalStaff.Models
{
    internal interface IResident : IHospitalWorker
    {
        Attending Supervisor { get; set; }
    }
}