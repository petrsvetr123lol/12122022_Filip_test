namespace _12122022_Filip_test
{
    partial class FormEdit
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
            this.updateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bDayPicker = new System.Windows.Forms.DateTimePicker();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.LnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(155, 223);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 33);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update data";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Birth Date";
            // 
            // bDayPicker
            // 
            this.bDayPicker.Location = new System.Drawing.Point(82, 171);
            this.bDayPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDayPicker.Name = "bDayPicker";
            this.bDayPicker.Size = new System.Drawing.Size(182, 27);
            this.bDayPicker.TabIndex = 19;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(82, 132);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(182, 27);
            this.emailTxt.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(82, 93);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(182, 27);
            this.phoneTxt.TabIndex = 16;
            // 
            // LnameTxt
            // 
            this.LnameTxt.Location = new System.Drawing.Point(82, 55);
            this.LnameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LnameTxt.Name = "LnameTxt";
            this.LnameTxt.Size = new System.Drawing.Size(182, 27);
            this.LnameTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "First name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(82, 16);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(182, 27);
            this.nameTxt.TabIndex = 11;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(39, 223);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 33);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 281);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bDayPicker);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.LnameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updateButton;
        private Label label5;
        private DateTimePicker bDayPicker;
        private TextBox emailTxt;
        private Label label4;
        private TextBox phoneTxt;
        private TextBox LnameTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox nameTxt;
        private Button cancelButton;
    }
}