namespace HospitalStaff.Models
{
    internal class RegisteredNurse : HospitalWorker, IRegisteredNurse
    {
        private INurseSupervisor _supervisor;

        public INurseSupervisor Supervisor
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
