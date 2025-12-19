using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmartTaskTracker
{
    public partial class Form1 : Form
    {
        // ==================================================
        // In-memory list to store all task items
        // ==================================================
        private List<TaskItem> tasks = new List<TaskItem>();
        public Form1()
        {
            InitializeComponent();
        }

        // ==================================================
        // Form Load
        // Initializes ComboBoxes and ListView settings
        // ==================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            UI_Cmb_Category.Items.AddRange(new string[] { "General","Work","Study","Personal"});
            UI_Cmb_Priority.Items.AddRange(new string[] { "Low", "Medium", "High" });
            UI_Cmb_Status.Items.AddRange(new string[] { "Pending", "Done" });

            UI_Cmb_Category.SelectedIndex = 0;
            UI_Cmb_Priority.SelectedIndex = 0;
            UI_Cmb_Status.SelectedIndex = 0;

            UI_Lvw_Tasks.View = View.Details;
            UI_Lvw_Tasks.FullRowSelect = true;
            UI_Lvw_Tasks.GridLines = true;

            UI_Lvw_Tasks.Columns.Add("Title", 150);
            UI_Lvw_Tasks.Columns.Add("Category", 100);
            UI_Lvw_Tasks.Columns.Add("Priority", 80);
            UI_Lvw_Tasks.Columns.Add("Status", 80);
        }

        // ==================================================
        // Refreshes the ListView from the task list
        // ==================================================
        private void RefreshList()
        {
            UI_Lvw_Tasks.Items.Clear();

            foreach (TaskItem task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Title);
                item.SubItems.Add(task.Category);
                item.SubItems.Add(task.Priority);
                item.SubItems.Add(task.Status);

                UI_Lvw_Tasks.Items.Add(item);
            }
        }

        // ==================================================
        // ADD Button
        // Creates a new task and adds it to the list
        // ==================================================
        private void UI_Btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UI_Tbx_Title.Text)){
                MessageBox.Show("Please enter a title.");
                return;
            }

            TaskItem task = new TaskItem
            {
                Title = UI_Tbx_Title.Text,
                Category = UI_Cmb_Category.Text,
                Priority = UI_Cmb_Priority.Text,
                Status = UI_Cmb_Status.Text,
            };

            tasks.Add(task);
            RefreshList();
            ClearInputs();
        }

        // ==================================================
        // Clears all input fields after Add/Edit
        // ==================================================
        private void ClearInputs()
        {
            UI_Tbx_Title.Clear();
            UI_Cmb_Category.SelectedIndex = 0;
            UI_Cmb_Priority.SelectedIndex = 0;
            UI_Cmb_Status.SelectedIndex = 0;
        }

        // ==================================================
        // EDIT Button
        // Updates the selected task with new input values
        // ==================================================
        private void UI_Btn_Edit_Click(object sender, EventArgs e)
        {
            if (UI_Lvw_Tasks.SelectedIndices.Count == 0)
                return;

            int index = UI_Lvw_Tasks.SelectedIndices[0];
            TaskItem task = tasks[index];

            task.Title = UI_Tbx_Title.Text;
            task.Category = UI_Cmb_Category.Text;
            task.Priority = UI_Cmb_Priority.Text;
            task.Status = UI_Cmb_Status.Text;

            RefreshList();
            ClearInputs();
        }

        // ==================================================
        // DELETE Button
        // Removes the selected task from the list
        // ==================================================
        private void UI_Btn_Delete_Click(object sender, EventArgs e)
        {
            if (UI_Lvw_Tasks.SelectedIndices.Count == 0)
                return;

            DialogResult result = MessageBox.Show(
                $"Delete {UI_Lvw_Tasks.SelectedIndices.Count} selected task(s)?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            // Remove from highest index to lowest to avoid shifting issues
            for (int i = UI_Lvw_Tasks.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = UI_Lvw_Tasks.SelectedIndices[i];
                tasks.RemoveAt(index);
            }

            RefreshList();
            ClearInputs();
        }

        // ==================================================
        // ListView Selection
        // Loads selected task data into input fields
        // ==================================================
        private void UI_Lvw_Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UI_Lvw_Tasks.SelectedIndices.Count == 0)
                return;

            int index = UI_Lvw_Tasks.SelectedIndices[0];
            TaskItem task = tasks[index];

            UI_Tbx_Title.Text = task.Title;
            UI_Cmb_Category.Text = task.Category;
            UI_Cmb_Priority.Text = task.Priority;
            UI_Cmb_Status.Text = task.Status;
        }

        // ==================================================
        // SAVE Button
        // Saves all tasks to a CSV file
        // ==================================================
        private void UI_Btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            sfd.Title = "Save Tasks";

            if(sfd.ShowDialog() != DialogResult.OK)
                return;

            using (StreamWriter writer = new StreamWriter(sfd.FileName))
            {
                foreach (TaskItem task in tasks)
                {
                    string line = $"{task.Title},{task.Category},{task.Priority},{task.Status}";
                    writer.WriteLine(line);
                }
            }

            MessageBox.Show("Tasks saved Successfully.");
        }

        // ==================================================
        // LOAD Button
        // Loads tasks from a CSV file
        // ==================================================
        private void UI_Btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files (*.csv)|*.csv";
            ofd.Title = "Load Tasks";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            foreach (string file in ofd.FileNames)
            {
                LoadTasksFromFile(file);
            }

            RefreshList();
            ClearInputs();

            MessageBox.Show("Tasks loaded successfully.");
        }

        // ==================================================
        // Loads tasks from a single CSV file
        // ==================================================
        private void LoadTasksFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    if (parts.Length != 4)
                        continue;

                    TaskItem task = new TaskItem
                    {
                        Title = parts[0],
                        Category = parts[1],
                        Priority = parts[2],
                        Status = parts[3]
                    };

                    tasks.Add(task);
                }
            }
        }


        // ==================================================
        // SORT Button
        // Sorts tasks by priority
        // ==================================================
        private void UI_Btn_Sort_Click(object sender, EventArgs e)
        {
            SortByPriority();
        }

        // ==================================================
        // Sorts tasks by Priority (High -> Medium -> Low)
        // ==================================================
        private void SortByPriority()
        {
            tasks = tasks
               .OrderByDescending(t => t.Priority == "High")
               .ThenByDescending(t => t.Priority == "Medium")
               .ThenByDescending(t => t.Priority == "Low")
               .ToList();

            RefreshList();
        }
    }

    // ==================================================
    // TaskItem Class
    // Represents a single task record
    // ==================================================
    class TaskItem
    {
        public string Title {  get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}
