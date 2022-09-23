namespace HospitalStaff
{
    internal class Resident : HospitalWorker
    {
        private Attending _supervisingAttending;

        public Attending SupervisingAttending
        {
            get { return _supervisingAttending; }
            set
            {
                _supervisingAttending = value;
                SupervisingAttending.SupervisedResidentsCount++;
            }
        }
    }
}
