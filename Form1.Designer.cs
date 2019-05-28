namespace Bee {
    partial class BeeFofm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.worketBeeJob = new System.Windows.Forms.ComboBox();
            this.shiftsNUM = new System.Windows.Forms.NumericUpDown();
            this.assignButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.jobLabel = new System.Windows.Forms.Label();
            this.shiftsLAbel = new System.Windows.Forms.Label();
            this.beeGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsNUM)).BeginInit();
            this.beeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // worketBeeJob
            // 
            this.worketBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.worketBeeJob.FormattingEnabled = true;
            this.worketBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufactoring",
            "Sting patrol",
            "Nectar collector"});
            this.worketBeeJob.Location = new System.Drawing.Point(6, 47);
            this.worketBeeJob.Name = "worketBeeJob";
            this.worketBeeJob.Size = new System.Drawing.Size(238, 21);
            this.worketBeeJob.TabIndex = 0;
            // 
            // shiftsNUM
            // 
            this.shiftsNUM.Location = new System.Drawing.Point(254, 47);
            this.shiftsNUM.Name = "shiftsNUM";
            this.shiftsNUM.Size = new System.Drawing.Size(120, 20);
            this.shiftsNUM.TabIndex = 1;
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(6, 84);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(368, 23);
            this.assignButton.TabIndex = 2;
            this.assignButton.Text = "Assign this job to a bee";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(415, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 127);
            this.button2.TabIndex = 3;
            this.button2.Text = "Work the next shift";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(12, 145);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(614, 227);
            this.reportTextBox.TabIndex = 4;
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(3, 31);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(24, 13);
            this.jobLabel.TabIndex = 3;
            this.jobLabel.Text = "Job";
            // 
            // shiftsLAbel
            // 
            this.shiftsLAbel.AutoSize = true;
            this.shiftsLAbel.Location = new System.Drawing.Point(251, 31);
            this.shiftsLAbel.Name = "shiftsLAbel";
            this.shiftsLAbel.Size = new System.Drawing.Size(33, 13);
            this.shiftsLAbel.TabIndex = 4;
            this.shiftsLAbel.Text = "Shifts";
            // 
            // beeGroupBox
            // 
            this.beeGroupBox.Controls.Add(this.shiftsLAbel);
            this.beeGroupBox.Controls.Add(this.assignButton);
            this.beeGroupBox.Controls.Add(this.jobLabel);
            this.beeGroupBox.Controls.Add(this.worketBeeJob);
            this.beeGroupBox.Controls.Add(this.shiftsNUM);
            this.beeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.beeGroupBox.Name = "beeGroupBox";
            this.beeGroupBox.Size = new System.Drawing.Size(397, 127);
            this.beeGroupBox.TabIndex = 5;
            this.beeGroupBox.TabStop = false;
            this.beeGroupBox.Text = "Worker Bee Assignements";
            // 
            // beeFofm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(639, 389);
            this.Controls.Add(this.beeGroupBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "beeFofm";
            this.Text = "Beehive Management System";
            ((System.ComponentModel.ISupportInitialize)(this.shiftsNUM)).EndInit();
            this.beeGroupBox.ResumeLayout(false);
            this.beeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label shiftsLAbel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.NumericUpDown shiftsNUM;
        private System.Windows.Forms.ComboBox worketBeeJob;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox reportTextBox;
        private System.Windows.Forms.GroupBox beeGroupBox;
    }
}

