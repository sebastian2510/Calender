namespace Calender
{
    partial class Form1
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
            this.NoteTxt = new System.Windows.Forms.TextBox();
            this.HeadTxt = new System.Windows.Forms.TextBox();
            this.Headline = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ListPanel = new System.Windows.Forms.ListBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Calender = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // NoteTxt
            // 
            this.NoteTxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NoteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteTxt.Location = new System.Drawing.Point(168, 283);
            this.NoteTxt.Multiline = true;
            this.NoteTxt.Name = "NoteTxt";
            this.NoteTxt.Size = new System.Drawing.Size(272, 198);
            this.NoteTxt.TabIndex = 1;
            // 
            // HeadTxt
            // 
            this.HeadTxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HeadTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeadTxt.Location = new System.Drawing.Point(168, 189);
            this.HeadTxt.Multiline = true;
            this.HeadTxt.Name = "HeadTxt";
            this.HeadTxt.Size = new System.Drawing.Size(191, 20);
            this.HeadTxt.TabIndex = 2;
            // 
            // Headline
            // 
            this.Headline.AutoSize = true;
            this.Headline.Location = new System.Drawing.Point(165, 173);
            this.Headline.Name = "Headline";
            this.Headline.Size = new System.Drawing.Size(49, 13);
            this.Headline.TabIndex = 3;
            this.Headline.Text = "Headline";
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Location = new System.Drawing.Point(168, 264);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(30, 13);
            this.Note.TabIndex = 4;
            this.Note.Text = "Note";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.SubmitBtn.FlatAppearance.BorderSize = 0;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Location = new System.Drawing.Point(365, 487);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 5;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ImportBtn.FlatAppearance.BorderSize = 0;
            this.ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportBtn.Location = new System.Drawing.Point(1047, 689);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(89, 53);
            this.ImportBtn.TabIndex = 6;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = false;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(1167, 689);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(95, 53);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ListPanel
            // 
            this.ListPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.ListPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListPanel.FormattingEnabled = true;
            this.ListPanel.Location = new System.Drawing.Point(1047, 1);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(215, 676);
            this.ListPanel.TabIndex = 0;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Location = new System.Drawing.Point(284, 487);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Calender
            // 
            this.Calender.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.Calender.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.Calender.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Calender.Location = new System.Drawing.Point(168, 217);
            this.Calender.Name = "Calender";
            this.Calender.Size = new System.Drawing.Size(191, 20);
            this.Calender.TabIndex = 9;
            this.Calender.ValueChanged += new System.EventHandler(this.Calender_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1262, 754);
            this.Controls.Add(this.Calender);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Headline);
            this.Controls.Add(this.HeadTxt);
            this.Controls.Add(this.NoteTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteTxt;
        private System.Windows.Forms.TextBox HeadTxt;
        private System.Windows.Forms.Label Headline;
        private System.Windows.Forms.Label Note;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ListBox ListPanel;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.DateTimePicker Calender;
    }
}

