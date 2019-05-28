

namespace Bee {
    interface INectarCollector :IWorker {
        int Nectar { get; set; }
        int FindFlowers();
        void GatherNectar();
        void ReturnToHive();
    }
}
