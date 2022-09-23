namespace HospitalStaff.Models
{
    internal class SurgicalTech : HospitalWorker, ISurgicalTech
    {
        public string Department { get; set; }
    }
}
