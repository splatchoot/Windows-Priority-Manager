namespace Windows11PriorityManager
{
    partial class Form1
    {
        private void InitializeComponent()
        {
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.buttonChangePriority = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProcesses.Columns.Add("Process Name");
            this.listViewProcesses.Columns.Add("Priority");
            this.Controls.Add(this.listViewProcesses);
            this.comboBoxPriority.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxPriority.Items.AddRange(new object[] { "High", "Normal", "Low", "Idle" });
            this.Controls.Add(this.comboBoxPriority);
            this.buttonChangePriority.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonChangePriority.Text = "Change Priority";
            this.Controls.Add(this.buttonChangePriority);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
