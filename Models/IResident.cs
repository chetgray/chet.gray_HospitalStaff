namespace HospitalStaff.Models
{
    internal interface IResident : IHospitalWorker
    {
        Attending SupervisingAttending { get; set; }
    }
}