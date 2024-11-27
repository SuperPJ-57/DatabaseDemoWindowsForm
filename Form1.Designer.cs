using Microsoft.Data.SqlClient;

namespace DatabaseDemoWindowsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            searchbox = new TextBox();
            search = new Button();
            lblRoll = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            txtRoll = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            submit = new Button();
            Roll = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            del = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Roll, name, address, phone, del });
            dataGridView1.Location = new Point(1, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(842, 293);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += Delete;
            dataGridView1.CellEndEdit += UpdateItem;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(554, 186);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(167, 27);
            searchbox.TabIndex = 1;
            // 
            // search
            // 
            search.BackColor = Color.DodgerBlue;
            search.ForeColor = Color.Transparent;
            search.Location = new Point(737, 186);
            search.Name = "search";
            search.Size = new Size(94, 29);
            search.TabIndex = 2;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += SearchRow;
            // 
            // lblRoll
            // 
            lblRoll.AutoSize = true;
            lblRoll.Location = new Point(16, 32);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new Size(35, 20);
            lblRoll.TabIndex = 3;
            lblRoll.Text = "Roll";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 68);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(16, 108);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(16, 142);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // txtRoll
            // 
            txtRoll.AllowDrop = true;
            txtRoll.Location = new Point(118, 32);
            txtRoll.Name = "txtRoll";
            txtRoll.Size = new Size(176, 27);
            txtRoll.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(176, 27);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(118, 101);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(176, 27);
            txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(118, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(176, 27);
            txtPhone.TabIndex = 10;
            // 
            // submit
            // 
            submit.BackColor = Color.DodgerBlue;
            submit.ForeColor = Color.Transparent;
            submit.Location = new Point(140, 186);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 11;
            submit.Text = "ADD";
            submit.UseVisualStyleBackColor = false;
            submit.Click += InsertOrUpdate;
            // 
            // Roll
            // 
            Roll.HeaderText = "Roll";
            Roll.MinimumWidth = 6;
            Roll.Name = "Roll";
            Roll.ReadOnly = true;
            Roll.Width = 70;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 200;
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.Width = 250;
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 145;
            // 
            // del
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            del.DefaultCellStyle = dataGridViewCellStyle1;
            del.FlatStyle = FlatStyle.Flat;
            del.HeaderText = "Action";
            del.MinimumWidth = 6;
            del.Name = "del";
            del.Text = "Delete";
            del.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 537);
            Controls.Add(submit);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtRoll);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblRoll);
            Controls.Add(search);
            Controls.Add(searchbox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion




        private DataGridView dataGridView1;

        

        private TextBox searchbox;
        private Button search;
        private Label lblRoll;
        private Label lblName;
        private Label lblAddress;
        private Label lblPhone;
        private TextBox txtRoll;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Button submit;
        private DataGridViewTextBoxColumn Roll;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewButtonColumn del;
    }
}
