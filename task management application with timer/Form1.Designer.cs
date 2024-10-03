namespace task_management_application_with_timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtTaskName = new TextBox();
            nudHours = new NumericUpDown();
            nudMinutes = new NumericUpDown();
            btnAddTask = new Button();
            lstTasks = new ListBox();
            lblTaskCount = new Label();
            btnRemoveTask = new Button();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nudHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).BeginInit();
            SuspendLayout();

            // Настройка формы
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10);

            // txtTaskName
            txtTaskName.Location = new Point(14, 14);
            txtTaskName.Margin = new Padding(4, 3, 4, 3);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(233, 30);
            txtTaskName.PlaceholderText = "Введите название задачи";

            // nudHours
            nudHours.Location = new Point(14, 54);
            nudHours.Margin = new Padding(4, 3, 4, 3);
            nudHours.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHours.Name = "nudHours";
            nudHours.Size = new Size(70, 30);
            nudHours.TabIndex = 1;

            // nudMinutes
            nudMinutes.Location = new Point(91, 54);
            nudMinutes.Margin = new Padding(4, 3, 4, 3);
            nudMinutes.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinutes.Name = "nudMinutes";
            nudMinutes.Size = new Size(70, 30);
            nudMinutes.TabIndex = 2;

            // btnAddTask
            btnAddTask.Location = new Point(168, 54);
            btnAddTask.Margin = new Padding(4, 3, 4, 3);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(88, 30);
            btnAddTask.Text = "Добавить";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;

            // lstTasks
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(14, 94);
            lstTasks.Margin = new Padding(4, 3, 4, 3);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(241, 109);
            lstTasks.TabIndex = 4;

            // lblTaskCount
            lblTaskCount.AutoSize = true;
            lblTaskCount.Location = new Point(14, 212);
            lblTaskCount.Margin = new Padding(4, 0, 4, 0);
            lblTaskCount.Name = "lblTaskCount";
            lblTaskCount.Size = new Size(240, 30);
            lblTaskCount.Text = "Оставшиеся задачи: 0";

            // btnRemoveTask
            btnRemoveTask.Location = new Point(14, 242);
            btnRemoveTask.Margin = new Padding(4, 3, 4, 3);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(88, 30);
            btnRemoveTask.Text = "Удалить";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += btnRemoveTask_Click;

            // Настройка таймера
            timer.Interval = 1000;
            timer.Tick += timer_Tick;

            // Добавление элементов управления на форму
            Controls.Add(txtTaskName);
            Controls.Add(nudHours);
            Controls.Add(nudMinutes);
            Controls.Add(btnAddTask);
            Controls.Add(lstTasks);
            Controls.Add(lblTaskCount);
            Controls.Add(btnRemoveTask);

            // Настройка формы
            this.ClientSize = new Size(289, 286);
            this.Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)nudHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblTaskCount;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Timer timer;
    }
}
