using System;


namespace Bee {
    class StingPatrol : Worker, IStringPatrol {
        public int AlertLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int StingerLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public StingPatrol(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg) {}

        public bool LookForEnemies() {
            throw new NotImplementedException();
        }

        public bool SharpenStinreg(int Length) {
            throw new NotImplementedException();
        }

        public bool Sting(string enemy) {
            throw new NotImplementedException();
        }
    }
}
}
