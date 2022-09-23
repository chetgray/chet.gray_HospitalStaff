namespace HospitalStaff.Models
{
    internal class NurseSupervisor : HospitalWorker, INurseSupervisor
    {
        public int SuperviseesCount { get; set; }
    }
}
