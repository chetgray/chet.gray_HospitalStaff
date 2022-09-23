namespace HospitalStaff.Models
{
    internal interface IAttending : IHospitalWorker
    {
        string Specialty { get; set; }
        int SuperviseesCount { get; set; }
    }
}