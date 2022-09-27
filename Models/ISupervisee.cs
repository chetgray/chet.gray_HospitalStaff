namespace HospitalStaff.Models
{
    internal interface ISupervisee<TSupervisor>
    {
        TSupervisor Supervisor { get; set; }
    }
}
