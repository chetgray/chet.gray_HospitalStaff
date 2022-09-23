namespace HospitalStaff.Models
{
    internal class Resident : HospitalWorker, IResident
    {
        private Attending _supervisor;

        public Attending Supervisor
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
