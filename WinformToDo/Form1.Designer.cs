namespace WinformToDo
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
            gbTaskForm = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblDueDate = new Label();
            txtDueDate = new TextBox();
            lblTaskBoxLabel = new Label();
            txtTaskDescription = new TextBox();
            gbTaskList = new GroupBox();
            lbTaskList = new ListBox();
            gbTaskForm.SuspendLayout();
            gbTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // gbTaskForm
            // 
            gbTaskForm.Controls.Add(btnClear);
            gbTaskForm.Controls.Add(btnAdd);
            gbTaskForm.Controls.Add(lblDueDate);
            gbTaskForm.Controls.Add(txtDueDate);
            gbTaskForm.Controls.Add(lblTaskBoxLabel);
            gbTaskForm.Controls.Add(txtTaskDescription);
            gbTaskForm.Location = new Point(12, 12);
            gbTaskForm.Name = "gbTaskForm";
            gbTaskForm.Size = new Size(420, 139);
            gbTaskForm.TabIndex = 0;
            gbTaskForm.TabStop = false;
            gbTaskForm.Text = "Task Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(204, 89);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(102, 38);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(312, 89);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add ToDo";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += submitForm;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(6, 63);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(72, 20);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Due Date";
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(104, 56);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.PlaceholderText = "2025-01-20";
            txtDueDate.Size = new Size(310, 27);
            txtDueDate.TabIndex = 2;
            txtDueDate.KeyPress += Form1_KeyPress;
            // 
            // lblTaskBoxLabel
            // 
            lblTaskBoxLabel.AutoSize = true;
            lblTaskBoxLabel.Location = new Point(6, 23);
            lblTaskBoxLabel.Name = "lblTaskBoxLabel";
            lblTaskBoxLabel.Size = new Size(36, 20);
            lblTaskBoxLabel.TabIndex = 1;
            lblTaskBoxLabel.Text = "Task";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(104, 23);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(310, 27);
            txtTaskDescription.TabIndex = 1;
            txtTaskDescription.KeyPress += Form1_KeyPress;
            // 
            // gbTaskList
            // 
            gbTaskList.Controls.Add(lbTaskList);
            gbTaskList.Location = new Point(12, 157);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(414, 523);
            gbTaskList.TabIndex = 1;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // lbTaskList
            // 
            lbTaskList.FormattingEnabled = true;
            lbTaskList.Location = new Point(0, 26);
            lbTaskList.Name = "lbTaskList";
            lbTaskList.Size = new Size(402, 504);
            lbTaskList.TabIndex = 0;
            lbTaskList.SelectedIndexChanged += lbTaskList_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 692);
            Controls.Add(gbTaskList);
            Controls.Add(gbTaskForm);
            Name = "Form1";
            Text = "Todo App";
            gbTaskForm.ResumeLayout(false);
            gbTaskForm.PerformLayout();
            gbTaskList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTaskForm;
        private Label lblTaskBoxLabel;
        private TextBox txtTaskDescription;
        private Button btnClear;
        private Button btnAdd;
        private Label lblDueDate;
        private TextBox txtDueDate;
        private GroupBox gbTaskList;
        private ListBox lbTaskList;
    }
}
