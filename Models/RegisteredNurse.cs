namespace HospitalStaff.Models
{
    internal class RegisteredNurse : HospitalWorker
    {
        private NurseSupervisor _supervisingNurseSupervisor;

        public NurseSupervisor SupervisingNurseSupervisor
        {
            get { return _supervisingNurseSupervisor; }
            set
            {
                if (!(_supervisingNurseSupervisor is null))
                {
                    SupervisingNurseSupervisor.SupervisedNursesCount--;
                }
                _supervisingNurseSupervisor = value;
                SupervisingNurseSupervisor.SupervisedNursesCount++;
            }
        }
    }
}
