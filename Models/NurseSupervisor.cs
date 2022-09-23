namespace HospitalStaff.Models
{
    internal class NurseSupervisor : HospitalWorker, INurseSupervisor
    {
        public int SupervisedNursesCount { get; set; }
    }
}
