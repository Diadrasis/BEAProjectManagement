namespace BEAProjectManagement
{
    partial class frmTimeSheet2
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCurrentPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 158);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // button1
            // 
            this.button1.Image = global::BEAProjectManagement.Properties.Resources.ok;
            this.button1.Location = new System.Drawing.Point(18, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 43);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCurrentPerson
            // 
            this.lblCurrentPerson.AutoSize = true;
            this.lblCurrentPerson.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCurrentPerson.Location = new System.Drawing.Point(83, 129);
            this.lblCurrentPerson.Name = "lblCurrentPerson";
            this.lblCurrentPerson.Size = new System.Drawing.Size(53, 20);
            this.lblCurrentPerson.TabIndex = 7;
            this.lblCurrentPerson.Text = "label2";
            // 
            // frmTimeSheet2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(894, 467);
            this.Controls.Add(this.lblCurrentPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "frmTimeSheet2";
            this.Load += new System.EventHandler(this.frmTimeSheet2_Load);
            this.Controls.SetChildIndex(this.monthCalendar1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lblCurrentPerson, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCurrentPerson;
    }
}
