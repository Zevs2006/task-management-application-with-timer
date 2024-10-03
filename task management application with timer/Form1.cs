using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace task_management_application_with_timer
{
    public partial class Form1 : Form
    {
        private class TaskItem
        {
            public string Name { get; set; }
            public TimeSpan RemainingTime { get; set; }
        }

        private List<TaskItem> tasks = new List<TaskItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text.Trim();
            int hours = (int)nudHours.Value;
            int minutes = (int)nudMinutes.Value;

            if (string.IsNullOrEmpty(taskName) || (hours == 0 && minutes == 0))
            {
                MessageBox.Show("Пожалуйста, введите название задачи и время.");
                return;
            }

            TaskItem newTask = new TaskItem
            {
                Name = taskName,
                RemainingTime = TimeSpan.FromHours(hours) + TimeSpan.FromMinutes(minutes)
            };

            tasks.Add(newTask);
            lstTasks.Items.Add(newTask.Name + " - " + newTask.RemainingTime.ToString(@"hh\:mm"));
            UpdateTaskCount();
            txtTaskName.Clear();
            nudHours.Value = 0;
            nudMinutes.Value = 0;

            if (!timer.Enabled)
            {
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = tasks.Count - 1; i >= 0; i--)
            {
                tasks[i].RemainingTime -= TimeSpan.FromSeconds(1);

                if (tasks[i].RemainingTime <= TimeSpan.Zero)
                {
                    MessageBox.Show($"Задача \"{tasks[i].Name}\" завершена!");
                    tasks.RemoveAt(i);
                    lstTasks.Items.RemoveAt(i);
                }
                else
                {
                    lstTasks.Items[i] = tasks[i].Name + " - " + tasks[i].RemainingTime.ToString(@"hh\:mm");
                }
            }

            UpdateTaskCount();

            if (tasks.Count == 0)
            {
                timer.Stop();
            }
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstTasks.SelectedIndex;
            if (selectedIndex >= 0)
            {
                tasks.RemoveAt(selectedIndex);
                lstTasks.Items.RemoveAt(selectedIndex);
                UpdateTaskCount();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите задачу для удаления.");
            }
        }

        private void UpdateTaskCount()
        {
            lblTaskCount.Text = $"Оставшиеся задачи: {tasks.Count}";
        }
    }
}
