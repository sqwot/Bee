using System;

namespace Bee {
    class Queen: Bee {
        private readonly Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers, double weightMg) :base(weightMg) {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numberOfShifts) {
            for (int i = 0; i < workers.Length; i++) 
                if (workers[i].DoThisJob(job, numberOfShifts)) return true;
            return false;
        }
        public string WorkTheNextShift() {
            shiftNumber++;
            double honeyConsumed = this.HoneyConsumptionRate();
            string report = "Отчет для смены №" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++) {
                honeyConsumed += workers[i].HoneyConsumptionRate();
                if (workers[i].DidYouFinish()) {
                    report += "Рабочий №" + (i + 1) + " закончил работу\r\n";
                }
                if (String.IsNullOrEmpty(workers[i].Job)) {
                    report += "Рабочий №" + (i + 1) + " не работает\r\n";
                } else {
                    if(workers[i].ShiftLeft > 0) {
                        report += "Рабочий №" + (i + 1) + " выполняет '" + workers[i].Job +"' еще " + workers[i].ShiftLeft + " смен\r\n";
                    } else {
                        report += "Рабочий №" + (i + 1) + " закончит '" + workers[i].Job + "' после этой смены\r\n";
                    }
                }

            }
            report += $"Total honey consumed for the shift: {honeyConsumed} units\r\n";

            return report;
        }
    }
}
