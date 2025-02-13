namespace WinformToDo
{
    partial class TaskControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMarkComplete = new Button();
            label1 = new Label();
            label2 = new Label();
            lblDueDate = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // btnMarkComplete
            // 
            btnMarkComplete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMarkComplete.AutoSize = true;
            btnMarkComplete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMarkComplete.Location = new Point(176, 3);
            btnMarkComplete.Name = "btnMarkComplete";
            btnMarkComplete.Size = new Size(121, 30);
            btnMarkComplete.TabIndex = 0;
            btnMarkComplete.Text = "Mark Complete";
            btnMarkComplete.UseVisualStyleBackColor = true;
            btnMarkComplete.Click += btnMarkComplete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Due Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 22);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(82, 2);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(85, 20);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "2025-01-01";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(2, 42);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(244, 62);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "this is a description of some task to be done";
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(lblDescription);
            Controls.Add(lblDueDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMarkComplete);
            MaximumSize = new Size(300, 0);
            Name = "TaskControl";
            Size = new Size(300, 104);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMarkComplete;
        private Label label1;
        private Label label2;
        private Label lblDueDate;
        private Label lblDescription;
    }
}
