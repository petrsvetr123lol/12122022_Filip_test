namespace _12122022_Filip_test
{
    partial class FormMain
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
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.avgAgeButton = new System.Windows.Forms.Button();
            this.oldestButton = new System.Windows.Forms.Button();
            this.youngestButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(14, 16);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(126, 31);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Insert new record";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(279, 16);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(126, 31);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete record";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(146, 16);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(126, 31);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit record";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(589, 204);
            this.countButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(83, 31);
            this.countButton.TabIndex = 6;
            this.countButton.Text = "Count ";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // avgAgeButton
            // 
            this.avgAgeButton.Location = new System.Drawing.Point(589, 243);
            this.avgAgeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.avgAgeButton.Name = "avgAgeButton";
            this.avgAgeButton.Size = new System.Drawing.Size(83, 31);
            this.avgAgeButton.TabIndex = 7;
            this.avgAgeButton.Text = "Avg age";
            this.avgAgeButton.UseVisualStyleBackColor = true;
            // 
            // oldestButton
            // 
            this.oldestButton.Location = new System.Drawing.Point(589, 282);
            this.oldestButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oldestButton.Name = "oldestButton";
            this.oldestButton.Size = new System.Drawing.Size(83, 31);
            this.oldestButton.TabIndex = 8;
            this.oldestButton.Text = "Oldest";
            this.oldestButton.UseVisualStyleBackColor = true;
            this.oldestButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // youngestButton
            // 
            this.youngestButton.Location = new System.Drawing.Point(589, 320);
            this.youngestButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.youngestButton.Name = "youngestButton";
            this.youngestButton.Size = new System.Drawing.Size(83, 31);
            this.youngestButton.TabIndex = 9;
            this.youngestButton.Text = "Youngest";
            this.youngestButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(14, 55);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(569, 296);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First name";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last name";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phone";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Birth date";
            this.columnHeader6.Width = 100;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 370);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.youngestButton);
            this.Controls.Add(this.oldestButton);
            this.Controls.Add(this.avgAgeButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button insertButton;
        private Button deleteButton;
        private Button editButton;
        private Button countButton;
        private Button avgAgeButton;
        private Button oldestButton;
        private Button youngestButton;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}