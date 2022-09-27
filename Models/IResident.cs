namespace HospitalStaff.Models
{
    internal interface IResident : IHospitalWorker, ISupervisee<IAttending>
    {
    }
}