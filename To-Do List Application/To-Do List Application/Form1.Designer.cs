namespace To_Do_List_Application
{
    partial class frmToDoList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkComplete = new System.Windows.Forms.Button();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.btnLowPriority = new System.Windows.Forms.RadioButton();
            this.btnMedPriority = new System.Windows.Forms.RadioButton();
            this.btnHighPriority = new System.Windows.Forms.RadioButton();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(125, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "To Do List";
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTask.Location = new System.Drawing.Point(20, 50);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(320, 30);
            this.txtTask.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(350, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.IntegralHeight = false;
            this.lstTasks.ItemHeight = 28;
            this.lstTasks.Location = new System.Drawing.Point(20, 90);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(470, 200);
            this.lstTasks.TabIndex = 3;
            this.lstTasks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstTasks_DrawItem);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.Color.LightBlue;
            this.btnEdit.Location = new System.Drawing.Point(20, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Task";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(180, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.9F, System.Drawing.FontStyle.Bold);
            this.btnMarkComplete.ForeColor = System.Drawing.Color.Orange;
            this.btnMarkComplete.Location = new System.Drawing.Point(340, 300);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(150, 30);
            this.btnMarkComplete.TabIndex = 6;
            this.btnMarkComplete.Text = "Mark Completed";
            this.btnMarkComplete.UseVisualStyleBackColor = true;
            this.btnMarkComplete.Click += new System.EventHandler(this.btnMarkComplete_Click);
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTasks.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalTasks.Location = new System.Drawing.Point(15, 340);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(250, 30);
            this.lblTotalTasks.TabIndex = 7;
            this.lblTotalTasks.Text = "Total Tasks: 0";
            // 
            // btnLowPriority
            // 
            this.btnLowPriority.AutoSize = true;
            this.btnLowPriority.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLowPriority.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLowPriority.Location = new System.Drawing.Point(20, 434);
            this.btnLowPriority.Name = "btnLowPriority";
            this.btnLowPriority.Size = new System.Drawing.Size(129, 27);
            this.btnLowPriority.TabIndex = 8;
            this.btnLowPriority.TabStop = true;
            this.btnLowPriority.Text = "Low Priority";
            this.btnLowPriority.UseVisualStyleBackColor = true;
            // 
            // btnMedPriority
            // 
            this.btnMedPriority.AutoSize = true;
            this.btnMedPriority.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMedPriority.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMedPriority.Location = new System.Drawing.Point(171, 434);
            this.btnMedPriority.Name = "btnMedPriority";
            this.btnMedPriority.Size = new System.Drawing.Size(163, 27);
            this.btnMedPriority.TabIndex = 9;
            this.btnMedPriority.TabStop = true;
            this.btnMedPriority.Text = "Medium Priority";
            this.btnMedPriority.UseVisualStyleBackColor = true;
            // 
            // btnHighPriority
            // 
            this.btnHighPriority.AutoSize = true;
            this.btnHighPriority.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHighPriority.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHighPriority.Location = new System.Drawing.Point(355, 434);
            this.btnHighPriority.Name = "btnHighPriority";
            this.btnHighPriority.Size = new System.Drawing.Size(135, 27);
            this.btnHighPriority.TabIndex = 10;
            this.btnHighPriority.TabStop = true;
            this.btnHighPriority.Text = "High Priority";
            this.btnHighPriority.UseVisualStyleBackColor = true;
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDarkMode.Location = new System.Drawing.Point(189, 341);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(118, 27);
            this.chkDarkMode.TabIndex = 11;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackColor.ForeColor = System.Drawing.Color.Orchid;
            this.btnBackColor.Location = new System.Drawing.Point(238, 377);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(252, 30);
            this.btnBackColor.TabIndex = 13;
            this.btnBackColor.Text = "Change Background Color";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnSpeech
            // 
            this.btnSpeech.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpeech.ForeColor = System.Drawing.Color.Gold;
            this.btnSpeech.Location = new System.Drawing.Point(340, 341);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(150, 30);
            this.btnSpeech.TabIndex = 14;
            this.btnSpeech.Text = "Speech to Text";
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd-MM-yy   hh:mm";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(20, 398);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(140, 22);
            this.dtpDueDate.TabIndex = 15;
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(17, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Set Due Date:";
            // 
            // frmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(502, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnSpeech);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.btnHighPriority);
            this.Controls.Add(this.btnMedPriority);
            this.Controls.Add(this.btnLowPriority);
            this.Controls.Add(this.lblTotalTasks);
            this.Controls.Add(this.btnMarkComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmToDoList_FormClosed);
            this.Load += new System.EventHandler(this.frmToDoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMarkComplete;
        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.RadioButton btnLowPriority;
        private System.Windows.Forms.RadioButton btnMedPriority;
        private System.Windows.Forms.RadioButton btnHighPriority;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnSpeech;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label1;
    }
}

