using System.Diagnostics;

public partial class Form1 : Form
{
    private ListView? listViewProcesses;

    private void Form1_Load(object sender, EventArgs e)
    {
        // Get a list of running processes.
        Process[] processes = Process.GetProcesses();

        // Initialize the ListView field.
        if (listViewProcesses == null)
        {
            this.listViewProcesses = new ListView();
        }

        // Populate the ListView with the list of running processes.
        foreach (Process process in processes)
        {
            ListViewItem item = new ListViewItem(process.ProcessName);
            item.SubItems.Add(process.PriorityClass.ToString());

            this.listViewProcesses.Items.Add(item);
        }

        // Add a ComboBox control to allow the user to select a priority level.
        ComboBox comboBoxPriority = new ComboBox();
        comboBoxPriority.Items.AddRange(new object[] { ProcessPriorityClass.High, ProcessPriorityClass.Normal, ProcessPriorityClass.Low, ProcessPriorityClass.Idle });

        comboBoxPriority.Dock = DockStyle.Top;

        // Add the ComboBox control to the form.
        this.Controls.Add(comboBoxPriority);

        // Add a button to allow the user to change the priority of the selected process.
        Button buttonChangePriority = new Button();
        buttonChangePriority.Text = "Change Priority";
        buttonChangePriority.Dock = DockStyle.Bottom;

        // Add the button control to the form.
        this.Controls.Add(buttonChangePriority);

        // Handle the button's Click event to change the priority of the selected process.
        buttonChangePriority.Click += (sender, e) =>
        {
            // Get the selected process.
            Process selectedProcess = this.listViewProcesses.SelectedItems[0].DataBoundItem as Process;

            if (selectedProcess != null)
            {
                // Set the priority of the selected process.
                selectedProcess.PriorityClass = (ProcessPriorityClass)comboBoxPriority.SelectedItem;
            }
        };
    }
}
