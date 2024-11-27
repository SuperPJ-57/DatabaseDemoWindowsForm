namespace DatabaseDemoWindowsForm
{
    partial class InsertForm
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
            lblRow = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            roll = new TextBox();
            phone = new TextBox();
            address = new TextBox();
            name = new TextBox();
            add = new Button();
            SuspendLayout();
            // 
            // lblRow
            // 
            lblRow.AutoSize = true;
            lblRow.Location = new Point(165, 73);
            lblRow.Name = "lblRow";
            lblRow.Size = new Size(35, 20);
            lblRow.TabIndex = 0;
            lblRow.Text = "Roll";
            lblRow.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(150, 126);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.Click += label2_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(148, 195);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(156, 250);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone";
            lblPhone.Click += label4_Click;
            // 
            // roll
            // 
            roll.Location = new Point(238, 70);
            roll.Name = "roll";
            roll.Size = new Size(256, 27);
            roll.TabIndex = 4;
            // 
            // phone
            // 
            phone.Location = new Point(238, 247);
            phone.Name = "phone";
            phone.Size = new Size(256, 27);
            phone.TabIndex = 5;
            // 
            // address
            // 
            address.Location = new Point(238, 192);
            address.Name = "address";
            address.Size = new Size(256, 27);
            address.TabIndex = 6;
            // 
            // name
            // 
            name.Location = new Point(238, 123);
            name.Name = "name";
            name.Size = new Size(256, 27);
            name.TabIndex = 7;
            name.TextChanged += textBox4_TextChanged;
            // 
            // add
            // 
            add.BackColor = SystemColors.MenuHighlight;
            add.Cursor = Cursors.Hand;
            add.ForeColor = Color.AliceBlue;
            add.Location = new Point(276, 318);
            add.Name = "add";
            add.Size = new Size(167, 69);
            add.TabIndex = 8;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += button1_Click;
            // 
            // InsertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add);
            Controls.Add(name);
            Controls.Add(address);
            Controls.Add(phone);
            Controls.Add(roll);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblRow);
            Name = "InsertForm";
            Text = "InsertForm";
            Load += InsertForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRow;
        private Label lblName;
        private Label lblAddress;
        private Label lblPhone;
        private TextBox roll;
        private TextBox phone;
        private TextBox address;
        private TextBox name;
        private Button add;
    }
}