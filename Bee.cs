using System;


namespace Bee {
    class Bee {
        private const double HONEY_UNITS_CONSUMED_PER_MG = 0.25;
        public double WeightMg { get; private set; }

        public Bee(double weightMg) {
            this.WeightMg = weightMg;
        }

        public virtual double HoneyConsumptionRate() {
            return WeightMg * HONEY_UNITS_CONSUMED_PER_MG;
        }
    }
}
