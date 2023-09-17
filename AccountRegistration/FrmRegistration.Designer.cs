namespace AccountRegistration
{
    partial class FrmRegistration
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
            cbProgram = new ComboBox();
            tbAddress = new TextBox();
            tbContactNo = new TextBox();
            tbAge = new TextBox();
            tbMiddleName = new TextBox();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbStudentNo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnNext = new Button();
            SuspendLayout();
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Computer Science (BSCS)", "Bachelor of Science in Information Systems (BSIS)", "2-yr. Information Technology (IT)", "2-yr. Associate in Computer Technology (ACT)", "Bachelor of Science in Business Administration (BSBA)", "Bachelor of Science in Accountancy (BSA)", "Bachelor of Science in Accounting Information System (BSAIS)", "Bachelor of Science in Management Accounting (BSMA)", "Bachelor of Science in Retail Technology and Consumer Science (BSRTCS)", "2-yr. Associate in Retail Technology (ART)", "Bachelor of Science in Hospitality Management (BSHM)", "Bachelor of Science in Culinary Management (BSCM)", "3-yr. Hotel and Restaurant Administration (HRA)", "2-yr. Hospitality and Restaurant Services (HRS)", "Bachelor of Science in Tourism Management (BSTM)", "2-yr. Tourism and Events Management (TEM)", "Bachelor of Science in Computer Engineering (BSCpE)", "Bachelor of Multimedia Arts (BMMA)", "Bachelor of Arts in Communication (BACOMM)", "Bachelor of Science in Marine Transportation (BSMT)", "Bachelor of Science in Marine Engineering (BSMarE)", "Bachelor of Science in Naval Architecture and Marine Engineering (BSNAME)" });
            cbProgram.Location = new Point(211, 45);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(402, 25);
            cbProgram.TabIndex = 31;
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbAddress.Location = new Point(23, 236);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(590, 65);
            tbAddress.TabIndex = 30;
            // 
            // tbContactNo
            // 
            tbContactNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbContactNo.Location = new Point(211, 175);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.Size = new Size(229, 25);
            tbContactNo.TabIndex = 29;
            // 
            // tbAge
            // 
            tbAge.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbAge.Location = new Point(23, 175);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(182, 25);
            tbAge.TabIndex = 28;
            // 
            // tbMiddleName
            // 
            tbMiddleName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbMiddleName.Location = new Point(412, 111);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(201, 25);
            tbMiddleName.TabIndex = 27;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbFirstName.Location = new Point(211, 111);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(195, 25);
            tbFirstName.TabIndex = 26;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbLastName.Location = new Point(23, 111);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(182, 25);
            tbLastName.TabIndex = 25;
            // 
            // tbStudentNo
            // 
            tbStudentNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbStudentNo.Location = new Point(23, 45);
            tbStudentNo.Name = "tbStudentNo";
            tbStudentNo.Size = new Size(182, 25);
            tbStudentNo.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(23, 218);
            label8.Name = "label8";
            label8.Size = new Size(60, 17);
            label8.TabIndex = 23;
            label8.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(208, 157);
            label7.Name = "label7";
            label7.Size = new Size(83, 17);
            label7.TabIndex = 22;
            label7.Text = "Contact No.:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 157);
            label6.Name = "label6";
            label6.Size = new Size(35, 17);
            label6.TabIndex = 21;
            label6.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(411, 93);
            label5.Name = "label5";
            label5.Size = new Size(92, 17);
            label5.TabIndex = 20;
            label5.Text = "Middle Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(210, 93);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 19;
            label4.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 93);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 18;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(211, 27);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 17;
            label2.Text = "Program:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 16;
            label1.Text = "Student No.:";
            // 
            // BtnNext
            // 
            BtnNext.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNext.Location = new Point(250, 313);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(150, 27);
            BtnNext.TabIndex = 33;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 367);
            Controls.Add(BtnNext);
            Controls.Add(cbProgram);
            Controls.Add(tbAddress);
            Controls.Add(tbContactNo);
            Controls.Add(tbAge);
            Controls.Add(tbMiddleName);
            Controls.Add(tbFirstName);
            Controls.Add(tbLastName);
            Controls.Add(tbStudentNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProgram;
        private TextBox tbAddress;
        private TextBox tbContactNo;
        private TextBox tbAge;
        private TextBox tbMiddleName;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbStudentNo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnNext;
    }
}