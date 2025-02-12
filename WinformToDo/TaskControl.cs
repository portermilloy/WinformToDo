using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformToDo
{
    public partial class TaskControl : UserControl
    {
        private Todo TaskData;

        public TaskControl(Todo task)
        {
            InitializeComponent();
            TaskData = task;

            // add code to set my labels to the data
            lblDescription.Text = TaskData.TaskDescription;
            lblDueDate.Text = TaskData.DueDate.ToShortDateString();
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
