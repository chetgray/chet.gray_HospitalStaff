namespace HospitalStaff.Models
{
    internal class RegisteredNurse : HospitalWorker, IRegisteredNurse
    {
        private NurseSupervisor _supervisor;

        public NurseSupervisor Supervisor
        {
            get { return _supervisor; }
            set
            {
                if (!(_supervisor is null))
                {
                    Supervisor.SuperviseesCount--;
                }
                _supervisor = value;
                Supervisor.SuperviseesCount++;
            }
        }
    }
}
