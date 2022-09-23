namespace HospitalStaff.Models
{
    internal class Attending : HospitalWorker, IAttending
    {
        public string Specialty { get; set; }
        public int SuperviseesCount { get; set; }
    }
}
