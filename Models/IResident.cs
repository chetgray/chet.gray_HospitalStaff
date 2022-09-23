namespace HospitalStaff.Models
{
    internal interface IResident : IHospitalWorker
    {
        IAttending Supervisor { get; set; }
    }
}