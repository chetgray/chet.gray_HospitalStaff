namespace HospitalStaff.Models
{
    internal interface INurseSupervisor : IHospitalWorker
    {
        int SupervisedNursesCount { get; set; }
    }
}