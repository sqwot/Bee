using System;

namespace Bee {
    internal class Worker: Bee {
        public int ShiftLeft => shiftToWork - shiftWorked;
        private readonly string[] jobsICanDo;
        private int shiftToWork;
        private int shiftWorked;
        private const double HONEY_UNITS_PER_SHIFT_WORKER = 0.65;
        public string Job { get; private set; }


        public Worker(string[] jobsICanDo, double weightMg) :base(weightMg){
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int numberOfShift) {
            if (!String.IsNullOrEmpty(Job)) return false;
            for (int i = 0; i < jobsICanDo.Length; i++) {
                if(jobsICanDo[i] == job) {
                    Job = job;
                    this.shiftToWork = numberOfShift;
                    shiftWorked = 0;
                    return true;
                }
            }
            return false;
        }
        public bool DidYouFinish() {
            if (String.IsNullOrEmpty(Job)) return false;
            shiftWorked++;
            if (shiftWorked > shiftToWork) {
                shiftToWork = 0;
                shiftWorked = 0;
                Job = "";
                return true;
            }
            return false;
        }
        public override double HoneyConsumptionRate() {
            return (base.HoneyConsumptionRate() + (shiftWorked * HONEY_UNITS_PER_SHIFT_WORKER));
        }
    }
}