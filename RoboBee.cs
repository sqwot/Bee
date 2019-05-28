using System;

namespace Bee {
    class RoboBee : Robot, IWorker {
        private readonly int shiftsToWork;
        private readonly int shiftsWorked;

        public string Job { get; private set; }

        public int ShiftLeft => shiftsToWork - shiftsWorked;

        public bool DoThisJob(string job, int shiftsToWork) {
            
            return false;
        }

        public void WorkOneShift() {
            throw new System.NotImplementedException();
        }
    }
}
