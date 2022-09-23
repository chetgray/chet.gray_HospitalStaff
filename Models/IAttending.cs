namespace HospitalStaff.Models
{
    internal interface IAttending : IHospitalWorker
    {
        string Specialty { get; set; }
        int SupervisedResidentsCount { get; set; }
    }
}