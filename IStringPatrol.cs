using System;

namespace Bee {
    interface IStringPatrol: IWorker {
        int AlertLevel { get; set; }
        int StingerLevel { get; set; }

        bool SharpenStinreg(int Length);
        bool LookForEnemies();
        bool Sting(string enemy);
    }
}
