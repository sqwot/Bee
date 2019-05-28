using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee {
    public partial class BeeFofm : Form {
        private readonly Queen queen;
        public BeeFofm() {
            InitializeComponent();
            worketBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufactoring" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "String patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufactoring", "Egg care", "Baby bee tutoring", "Hive maintenance", "String patrol" }, 155);
            queen = new Queen(workers, 275);

        }

        private void AssignButton_Click(object sender, EventArgs e) {
            if (queen.AssignWork(worketBeeJob.Text, (int)shiftsNUM.Value) == false) {
                MessageBox.Show($"Для задания '{worketBeeJob.Text}' рабочих нет", "Матка говорит...");
            } else {
                MessageBox.Show($"Задание '{worketBeeJob.Text}' будет закончено через {shiftsNUM.Value} смен", "Матка говорит...");
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            reportTextBox.Text = queen.WorkTheNextShift();
        }
    }
}
