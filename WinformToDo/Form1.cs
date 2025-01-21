namespace WinformToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //where we handle the add event
            Todo myTodo = new Todo(txtTaskDescription.Text, new DateTime());

            MessageBox mb


        }
    }
}
