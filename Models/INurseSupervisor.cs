namespace HospitalStaff.Models
{
    internal interface INurseSupervisor : IHospitalWorker
    {
        int SuperviseesCount { get; set; }
    }
}