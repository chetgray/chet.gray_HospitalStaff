﻿namespace HospitalStaff.Models
{
    internal class Resident : HospitalWorker
    {
        private Attending _supervisingAttending;

        public Attending SupervisingAttending
        {
            get { return _supervisingAttending; }
            set
            {
                if (!(_supervisingAttending is null))
                {
                    SupervisingAttending.SupervisedResidentsCount--;
                }
                _supervisingAttending = value;
                SupervisingAttending.SupervisedResidentsCount++;
            }
        }
    }
}
