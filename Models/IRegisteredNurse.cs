namespace HospitalStaff.Models
{
    internal interface IRegisteredNurse : IHospitalWorker
    {
        INurseSupervisor Supervisor { get; set; }
    }
}