namespace WinformToDo
{
    public partial class Form1 : Form
    {
        private List<Todo> TaskList { get; set; }

        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }



        private void submitForm(object sender, EventArgs e)
        {
            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Description is empty, please provide a description.");
                return;
            }

            if(Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Description needs to be created.");
                return;
            }
            
            if(Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("Missing a due date.");
                return;
            }

            if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorrectly formatted, please resubmit.");
                return;
            }

            //where we handle the add event
            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));



            TaskList.Add(myTodo);

            UpdateListBox();


            ClearForm();

        }

        public void UpdateListBox()
        {
            lbTaskList.Items.Clear();

            var list = TaskList
                .Where(t => t.IsDone == false)
                .OrderBy(t => t.DueDate)
                .ToList();


            for (int i =0; i < list.Count; i++)
            {
                lbTaskList.Items.Add(list[i].ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearForm();
            MessageBox.Show("Form Cleared");
        }

        private void ClearForm()
        {
            txtTaskDescription.Clear();
            txtDueDate.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submitForm(sender, e);
            }
        }
    }
}
