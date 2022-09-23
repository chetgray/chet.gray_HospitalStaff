namespace HospitalStaff
{
    internal class Attending : HospitalWorker
    {
        public string Specialty { get; set; }
        public int SupervisedResidentsCount { get; set; }
    }
}
