namespace HospitalStaff.Models
{
    internal interface IRegisteredNurse : IHospitalWorker
    {
        NurseSupervisor Supervisor { get; set; }
    }
}