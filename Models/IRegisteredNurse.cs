namespace HospitalStaff.Models
{
    internal interface IRegisteredNurse : IHospitalWorker, ISupervisee<INurseSupervisor>
    {
    }
}