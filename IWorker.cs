namespace Bee {
    interface IWorker {
        string Job { get; }
        int ShiftLeft { get; }
        void DoThisJob(string jobs, int shifts);
        void WorkOneShift();

    }
}
