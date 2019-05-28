using System;


namespace Bee {
    class NectarCollector : Worker, INectarCollector {
        public NectarCollector(string[] jobsICanDo, double weightMg) : base(jobsICanDo, weightMg) {}

        public int Nectar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int FindFlowers() {
            throw new NotImplementedException();
        }

        public void GatherNectar() {
            throw new NotImplementedException();
        }

        public void ReturnToHive() {
            throw new NotImplementedException();
        }
    }
}
