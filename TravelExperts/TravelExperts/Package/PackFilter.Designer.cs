namespace TravelExperts
{
    partial class PackFilter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtNameCont = new System.Windows.Forms.TextBox();
            this.dtpStartDateBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDateFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDateBegin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name contains: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date between:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "And:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date between:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "And:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(365, 130);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(89, 26);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtNameCont
            // 
            this.txtNameCont.Location = new System.Drawing.Point(155, 22);
            this.txtNameCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameCont.Name = "txtNameCont";
            this.txtNameCont.Size = new System.Drawing.Size(300, 22);
            this.txtNameCont.TabIndex = 6;
            // 
            // dtpStartDateBegin
            // 
            this.dtpStartDateBegin.CustomFormat = "dd MMM yyyy";
            this.dtpStartDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDateBegin.Location = new System.Drawing.Point(155, 56);
            this.dtpStartDateBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDateBegin.Name = "dtpStartDateBegin";
            this.dtpStartDateBegin.Size = new System.Drawing.Size(120, 22);
            this.dtpStartDateBegin.TabIndex = 7;
            this.dtpStartDateBegin.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpStartDateBegin.Enter += new System.EventHandler(this.dtpStartDateBegin_Enter);
            this.dtpStartDateBegin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpStartDateBegin_KeyDown);
            // 
            // dtpStartDateFinish
            // 
            this.dtpStartDateFinish.CustomFormat = "dd MMM yyyy";
            this.dtpStartDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDateFinish.Location = new System.Drawing.Point(326, 57);
            this.dtpStartDateFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDateFinish.Name = "dtpStartDateFinish";
            this.dtpStartDateFinish.Size = new System.Drawing.Size(128, 22);
            this.dtpStartDateFinish.TabIndex = 8;
            this.dtpStartDateFinish.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpStartDateFinish.Enter += new System.EventHandler(this.dtpStartDateFinish_Enter);
            this.dtpStartDateFinish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpStartDateFinish_KeyDown);
            // 
            // dtpEndDateFinish
            // 
            this.dtpEndDateFinish.CustomFormat = "dd MMM yyyy";
            this.dtpEndDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDateFinish.Location = new System.Drawing.Point(326, 93);
            this.dtpEndDateFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDateFinish.Name = "dtpEndDateFinish";
            this.dtpEndDateFinish.Size = new System.Drawing.Size(128, 22);
            this.dtpEndDateFinish.TabIndex = 10;
            this.dtpEndDateFinish.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpEndDateFinish.Enter += new System.EventHandler(this.dtpEndDateFinish_Enter);
            this.dtpEndDateFinish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpEndDateFinish_KeyDown);
            // 
            // dtpEndDateBegin
            // 
            this.dtpEndDateBegin.CustomFormat = "dd MMM yyyy";
            this.dtpEndDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDateBegin.Location = new System.Drawing.Point(155, 92);
            this.dtpEndDateBegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDateBegin.Name = "dtpEndDateBegin";
            this.dtpEndDateBegin.Size = new System.Drawing.Size(120, 22);
            this.dtpEndDateBegin.TabIndex = 9;
            this.dtpEndDateBegin.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpEndDateBegin.Enter += new System.EventHandler(this.dtpEndDateBegin_Enter);
            this.dtpEndDateBegin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpEndDateBegin_KeyDown);
            // 
            // PackFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 170);
            this.Controls.Add(this.dtpEndDateFinish);
            this.Controls.Add(this.dtpEndDateBegin);
            this.Controls.Add(this.dtpStartDateFinish);
            this.Controls.Add(this.dtpStartDateBegin);
            this.Controls.Add(this.txtNameCont);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(370, 110);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PackFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApply;
        public System.Windows.Forms.TextBox txtNameCont;
        public System.Windows.Forms.DateTimePicker dtpStartDateBegin;
        public System.Windows.Forms.DateTimePicker dtpStartDateFinish;
        public System.Windows.Forms.DateTimePicker dtpEndDateFinish;
        public System.Windows.Forms.DateTimePicker dtpEndDateBegin;
    }
}