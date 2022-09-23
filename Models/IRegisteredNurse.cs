namespace HospitalStaff.Models
{
    internal interface IRegisteredNurse : IHospitalWorker
    {
        NurseSupervisor SupervisingNurseSupervisor { get; set; }
    }
}