namespace PayRoll_GUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.btnNextToAddress = new System.Windows.Forms.Button();
            this.txbHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txbWage = new System.Windows.Forms.TextBox();
            this.lblWage = new System.Windows.Forms.Label();
            this.txbJobTitle = new System.Windows.Forms.TextBox();
            this.chbOnPayroll = new System.Windows.Forms.CheckBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txbPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txblastName = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.pnlAddAddress = new System.Windows.Forms.Panel();
            this.txbAppNum = new System.Windows.Forms.TextBox();
            this.txbZip = new System.Windows.Forms.TextBox();
            this.txbState = new System.Windows.Forms.TextBox();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.txbAdress = new System.Windows.Forms.TextBox();
            this.lblConfirmText = new System.Windows.Forms.Label();
            this.btnConfirmAddEmployee = new System.Windows.Forms.Button();
            this.btnBackToAddEmployee = new System.Windows.Forms.Button();
            this.lblAppNum = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEnterAdress = new System.Windows.Forms.Label();
            this.btnAddEmplyoyee = new System.Windows.Forms.Button();
            this.btnDisplayEmployees = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.pnlDisplayEmployees = new System.Windows.Forms.Panel();
            this.grdEmployeeData = new System.Windows.Forms.DataGridView();
            this.pnlRemoveEmployee = new System.Windows.Forms.Panel();
            this.lblConfirmRemove = new System.Windows.Forms.Label();
            this.butConfirmRemove = new System.Windows.Forms.Button();
            this.txbRemoveLastName = new System.Windows.Forms.TextBox();
            this.txbRemoveFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPayEmployees = new System.Windows.Forms.Button();
            this.lblPayEmployees = new System.Windows.Forms.Label();
            this.pnlAddEmployee.SuspendLayout();
            this.pnlAddAddress.SuspendLayout();
            this.pnlDisplayEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeData)).BeginInit();
            this.pnlRemoveEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(315, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Payroll";
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.Controls.Add(this.btnNextToAddress);
            this.pnlAddEmployee.Controls.Add(this.txbHoursWorked);
            this.pnlAddEmployee.Controls.Add(this.lblHoursWorked);
            this.pnlAddEmployee.Controls.Add(this.txbWage);
            this.pnlAddEmployee.Controls.Add(this.lblWage);
            this.pnlAddEmployee.Controls.Add(this.txbJobTitle);
            this.pnlAddEmployee.Controls.Add(this.chbOnPayroll);
            this.pnlAddEmployee.Controls.Add(this.lblJobTitle);
            this.pnlAddEmployee.Controls.Add(this.txbPhoneNum);
            this.pnlAddEmployee.Controls.Add(this.lblPhoneNumber);
            this.pnlAddEmployee.Controls.Add(this.txblastName);
            this.pnlAddEmployee.Controls.Add(this.lblLast);
            this.pnlAddEmployee.Controls.Add(this.lblFirstName);
            this.pnlAddEmployee.Controls.Add(this.label1);
            this.pnlAddEmployee.Controls.Add(this.txbFirstName);
            this.pnlAddEmployee.Location = new System.Drawing.Point(320, 80);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(447, 285);
            this.pnlAddEmployee.TabIndex = 1;
            this.pnlAddEmployee.Visible = false;
            // 
            // btnNextToAddress
            // 
            this.btnNextToAddress.Location = new System.Drawing.Point(129, 209);
            this.btnNextToAddress.Name = "btnNextToAddress";
            this.btnNextToAddress.Size = new System.Drawing.Size(75, 23);
            this.btnNextToAddress.TabIndex = 12;
            this.btnNextToAddress.Text = "Next";
            this.btnNextToAddress.UseVisualStyleBackColor = true;
            this.btnNextToAddress.Click += new System.EventHandler(this.LoadAddAddressMenu);
            // 
            // txbHoursWorked
            // 
            this.txbHoursWorked.Location = new System.Drawing.Point(129, 172);
            this.txbHoursWorked.Name = "txbHoursWorked";
            this.txbHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txbHoursWorked.TabIndex = 11;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(129, 155);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(76, 13);
            this.lblHoursWorked.TabIndex = 10;
            this.lblHoursWorked.Text = "Hours Worked";
            // 
            // txbWage
            // 
            this.txbWage.Location = new System.Drawing.Point(23, 172);
            this.txbWage.Name = "txbWage";
            this.txbWage.Size = new System.Drawing.Size(100, 20);
            this.txbWage.TabIndex = 9;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(20, 155);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(36, 13);
            this.lblWage.TabIndex = 8;
            this.lblWage.Text = "Wage";
            // 
            // txbJobTitle
            // 
            this.txbJobTitle.Location = new System.Drawing.Point(23, 128);
            this.txbJobTitle.Name = "txbJobTitle";
            this.txbJobTitle.Size = new System.Drawing.Size(100, 20);
            this.txbJobTitle.TabIndex = 7;
            // 
            // chbOnPayroll
            // 
            this.chbOnPayroll.AutoSize = true;
            this.chbOnPayroll.Location = new System.Drawing.Point(23, 209);
            this.chbOnPayroll.Name = "chbOnPayroll";
            this.chbOnPayroll.Size = new System.Drawing.Size(74, 17);
            this.chbOnPayroll.TabIndex = 3;
            this.chbOnPayroll.Text = "On Payroll";
            this.chbOnPayroll.UseVisualStyleBackColor = true;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(20, 111);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(44, 13);
            this.lblJobTitle.TabIndex = 6;
            this.lblJobTitle.Text = "JobTitle";
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Location = new System.Drawing.Point(23, 84);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txbPhoneNum.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 67);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txblastName
            // 
            this.txblastName.Location = new System.Drawing.Point(129, 45);
            this.txblastName.Name = "txblastName";
            this.txblastName.Size = new System.Drawing.Size(100, 20);
            this.txblastName.TabIndex = 3;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(126, 29);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(58, 13);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Employees Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(23, 45);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 1;
            // 
            // pnlAddAddress
            // 
            this.pnlAddAddress.Controls.Add(this.txbAppNum);
            this.pnlAddAddress.Controls.Add(this.txbZip);
            this.pnlAddAddress.Controls.Add(this.txbState);
            this.pnlAddAddress.Controls.Add(this.txbCity);
            this.pnlAddAddress.Controls.Add(this.txbAdress);
            this.pnlAddAddress.Controls.Add(this.lblConfirmText);
            this.pnlAddAddress.Controls.Add(this.btnConfirmAddEmployee);
            this.pnlAddAddress.Controls.Add(this.btnBackToAddEmployee);
            this.pnlAddAddress.Controls.Add(this.lblAppNum);
            this.pnlAddAddress.Controls.Add(this.lblZip);
            this.pnlAddAddress.Controls.Add(this.lblCity);
            this.pnlAddAddress.Controls.Add(this.lblState);
            this.pnlAddAddress.Controls.Add(this.lblAddress);
            this.pnlAddAddress.Controls.Add(this.lblEnterAdress);
            this.pnlAddAddress.Location = new System.Drawing.Point(320, 80);
            this.pnlAddAddress.Name = "pnlAddAddress";
            this.pnlAddAddress.Size = new System.Drawing.Size(401, 285);
            this.pnlAddAddress.TabIndex = 7;
            this.pnlAddAddress.Visible = false;
            // 
            // txbAppNum
            // 
            this.txbAppNum.Location = new System.Drawing.Point(42, 105);
            this.txbAppNum.Name = "txbAppNum";
            this.txbAppNum.Size = new System.Drawing.Size(29, 20);
            this.txbAppNum.TabIndex = 20;
            // 
            // txbZip
            // 
            this.txbZip.Location = new System.Drawing.Point(229, 55);
            this.txbZip.Name = "txbZip";
            this.txbZip.Size = new System.Drawing.Size(29, 20);
            this.txbZip.TabIndex = 19;
            // 
            // txbState
            // 
            this.txbState.Location = new System.Drawing.Point(194, 55);
            this.txbState.Name = "txbState";
            this.txbState.Size = new System.Drawing.Size(29, 20);
            this.txbState.TabIndex = 18;
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(159, 55);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(29, 20);
            this.txbCity.TabIndex = 17;
            // 
            // txbAdress
            // 
            this.txbAdress.Location = new System.Drawing.Point(42, 55);
            this.txbAdress.Name = "txbAdress";
            this.txbAdress.Size = new System.Drawing.Size(111, 20);
            this.txbAdress.TabIndex = 16;
            // 
            // lblConfirmText
            // 
            this.lblConfirmText.AutoSize = true;
            this.lblConfirmText.Location = new System.Drawing.Point(228, 175);
            this.lblConfirmText.Name = "lblConfirmText";
            this.lblConfirmText.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmText.TabIndex = 15;
            // 
            // btnConfirmAddEmployee
            // 
            this.btnConfirmAddEmployee.Location = new System.Drawing.Point(231, 200);
            this.btnConfirmAddEmployee.Name = "btnConfirmAddEmployee";
            this.btnConfirmAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddEmployee.TabIndex = 14;
            this.btnConfirmAddEmployee.Text = "Confirm";
            this.btnConfirmAddEmployee.UseVisualStyleBackColor = true;
            this.btnConfirmAddEmployee.Click += new System.EventHandler(this.ConfirmNewEmployeeData);
            // 
            // btnBackToAddEmployee
            // 
            this.btnBackToAddEmployee.Location = new System.Drawing.Point(42, 200);
            this.btnBackToAddEmployee.Name = "btnBackToAddEmployee";
            this.btnBackToAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnBackToAddEmployee.TabIndex = 13;
            this.btnBackToAddEmployee.Text = "Back";
            this.btnBackToAddEmployee.UseVisualStyleBackColor = true;
            this.btnBackToAddEmployee.Click += new System.EventHandler(this.LoadAddEmployeeMenu);
            // 
            // lblAppNum
            // 
            this.lblAppNum.AutoSize = true;
            this.lblAppNum.Location = new System.Drawing.Point(39, 89);
            this.lblAppNum.Name = "lblAppNum";
            this.lblAppNum.Size = new System.Drawing.Size(92, 13);
            this.lblAppNum.TabIndex = 12;
            this.lblAppNum.Text = "ApartmentNumber";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(236, 38);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 11;
            this.lblZip.Text = "Zip";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(156, 39);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(191, 39);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(39, 38);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lblEnterAdress
            // 
            this.lblEnterAdress.AutoSize = true;
            this.lblEnterAdress.Location = new System.Drawing.Point(100, 10);
            this.lblEnterAdress.Name = "lblEnterAdress";
            this.lblEnterAdress.Size = new System.Drawing.Size(145, 13);
            this.lblEnterAdress.TabIndex = 7;
            this.lblEnterAdress.Text = "Enter the Employees Address";
            // 
            // btnAddEmplyoyee
            // 
            this.btnAddEmplyoyee.Location = new System.Drawing.Point(181, 102);
            this.btnAddEmplyoyee.Name = "btnAddEmplyoyee";
            this.btnAddEmplyoyee.Size = new System.Drawing.Size(104, 23);
            this.btnAddEmplyoyee.TabIndex = 0;
            this.btnAddEmplyoyee.Text = "Add Employee";
            this.btnAddEmplyoyee.UseVisualStyleBackColor = true;
            this.btnAddEmplyoyee.Click += new System.EventHandler(this.LoadAddEmployeeMenu);
            // 
            // btnDisplayEmployees
            // 
            this.btnDisplayEmployees.Location = new System.Drawing.Point(181, 160);
            this.btnDisplayEmployees.Name = "btnDisplayEmployees";
            this.btnDisplayEmployees.Size = new System.Drawing.Size(104, 23);
            this.btnDisplayEmployees.TabIndex = 4;
            this.btnDisplayEmployees.Text = "Display Employees";
            this.btnDisplayEmployees.UseVisualStyleBackColor = true;
            this.btnDisplayEmployees.Click += new System.EventHandler(this.LoadDisplayEmployeesMenu);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(181, 131);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(104, 23);
            this.btnRemoveEmployee.TabIndex = 5;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.LoadRemoveEmployeeMenu);
            // 
            // pnlDisplayEmployees
            // 
            this.pnlDisplayEmployees.Controls.Add(this.lblPayEmployees);
            this.pnlDisplayEmployees.Controls.Add(this.btnPayEmployees);
            this.pnlDisplayEmployees.Controls.Add(this.grdEmployeeData);
            this.pnlDisplayEmployees.Location = new System.Drawing.Point(320, 80);
            this.pnlDisplayEmployees.Name = "pnlDisplayEmployees";
            this.pnlDisplayEmployees.Size = new System.Drawing.Size(678, 461);
            this.pnlDisplayEmployees.TabIndex = 6;
            this.pnlDisplayEmployees.Visible = false;
            // 
            // grdEmployeeData
            // 
            this.grdEmployeeData.AllowUserToAddRows = false;
            this.grdEmployeeData.AllowUserToDeleteRows = false;
            this.grdEmployeeData.AllowUserToResizeRows = false;
            this.grdEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployeeData.Location = new System.Drawing.Point(3, 44);
            this.grdEmployeeData.Name = "grdEmployeeData";
            this.grdEmployeeData.ReadOnly = true;
            this.grdEmployeeData.Size = new System.Drawing.Size(646, 289);
            this.grdEmployeeData.TabIndex = 0;
            // 
            // pnlRemoveEmployee
            // 
            this.pnlRemoveEmployee.Controls.Add(this.lblConfirmRemove);
            this.pnlRemoveEmployee.Controls.Add(this.butConfirmRemove);
            this.pnlRemoveEmployee.Controls.Add(this.txbRemoveLastName);
            this.pnlRemoveEmployee.Controls.Add(this.txbRemoveFirstName);
            this.pnlRemoveEmployee.Controls.Add(this.label4);
            this.pnlRemoveEmployee.Controls.Add(this.label3);
            this.pnlRemoveEmployee.Controls.Add(this.label2);
            this.pnlRemoveEmployee.Location = new System.Drawing.Point(320, 80);
            this.pnlRemoveEmployee.Name = "pnlRemoveEmployee";
            this.pnlRemoveEmployee.Size = new System.Drawing.Size(459, 253);
            this.pnlRemoveEmployee.TabIndex = 2;
            this.pnlRemoveEmployee.Visible = false;
            // 
            // lblConfirmRemove
            // 
            this.lblConfirmRemove.AutoSize = true;
            this.lblConfirmRemove.Location = new System.Drawing.Point(123, 187);
            this.lblConfirmRemove.Name = "lblConfirmRemove";
            this.lblConfirmRemove.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmRemove.TabIndex = 6;
            // 
            // butConfirmRemove
            // 
            this.butConfirmRemove.Location = new System.Drawing.Point(123, 208);
            this.butConfirmRemove.Name = "butConfirmRemove";
            this.butConfirmRemove.Size = new System.Drawing.Size(75, 23);
            this.butConfirmRemove.TabIndex = 5;
            this.butConfirmRemove.Text = "Confirm";
            this.butConfirmRemove.UseVisualStyleBackColor = true;
            this.butConfirmRemove.Click += new System.EventHandler(this.RemoveEmployee);
            // 
            // txbRemoveLastName
            // 
            this.txbRemoveLastName.Location = new System.Drawing.Point(147, 60);
            this.txbRemoveLastName.Name = "txbRemoveLastName";
            this.txbRemoveLastName.Size = new System.Drawing.Size(79, 20);
            this.txbRemoveLastName.TabIndex = 4;
            // 
            // txbRemoveFirstName
            // 
            this.txbRemoveFirstName.Location = new System.Drawing.Point(41, 60);
            this.txbRemoveFirstName.Name = "txbRemoveFirstName";
            this.txbRemoveFirstName.Size = new System.Drawing.Size(79, 20);
            this.txbRemoveFirstName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter the Name of the Employee you want to Remove";
            // 
            // btnPayEmployees
            // 
            this.btnPayEmployees.Location = new System.Drawing.Point(223, 413);
            this.btnPayEmployees.Name = "btnPayEmployees";
            this.btnPayEmployees.Size = new System.Drawing.Size(145, 23);
            this.btnPayEmployees.TabIndex = 1;
            this.btnPayEmployees.Text = "Pay Employees";
            this.btnPayEmployees.UseVisualStyleBackColor = true;
            this.btnPayEmployees.Click += new System.EventHandler(this.PayEmployees);
            // 
            // lblPayEmployees
            // 
            this.lblPayEmployees.AutoSize = true;
            this.lblPayEmployees.Location = new System.Drawing.Point(226, 397);
            this.lblPayEmployees.Name = "lblPayEmployees";
            this.lblPayEmployees.Size = new System.Drawing.Size(59, 13);
            this.lblPayEmployees.TabIndex = 2;
            this.lblPayEmployees.Text = "You Paid : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.pnlAddAddress);
            this.Controls.Add(this.pnlRemoveEmployee);
            this.Controls.Add(this.pnlDisplayEmployees);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnDisplayEmployees);
            this.Controls.Add(this.btnAddEmplyoyee);
            this.Controls.Add(this.pnlAddEmployee);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.pnlAddAddress.ResumeLayout(false);
            this.pnlAddAddress.PerformLayout();
            this.pnlDisplayEmployees.ResumeLayout(false);
            this.pnlDisplayEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployeeData)).EndInit();
            this.pnlRemoveEmployee.ResumeLayout(false);
            this.pnlRemoveEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Button btnAddEmplyoyee;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.CheckBox chbOnPayroll;
        private System.Windows.Forms.Button btnDisplayEmployees;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDisplayEmployees;
        private System.Windows.Forms.Panel pnlRemoveEmployee;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txblastName;
        private System.Windows.Forms.TextBox txbPhoneNum;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txbHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txbWage;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.TextBox txbJobTitle;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Button btnNextToAddress;
        private System.Windows.Forms.Panel pnlAddAddress;
        private System.Windows.Forms.Label lblEnterAdress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAppNum;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txbAppNum;
        private System.Windows.Forms.TextBox txbZip;
        private System.Windows.Forms.TextBox txbState;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.TextBox txbAdress;
        private System.Windows.Forms.Label lblConfirmText;
        private System.Windows.Forms.Button btnConfirmAddEmployee;
        private System.Windows.Forms.Button btnBackToAddEmployee;
        private System.Windows.Forms.Button butConfirmRemove;
        private System.Windows.Forms.TextBox txbRemoveLastName;
        private System.Windows.Forms.TextBox txbRemoveFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConfirmRemove;
        private System.Windows.Forms.DataGridView grdEmployeeData;
        private System.Windows.Forms.Label lblPayEmployees;
        private System.Windows.Forms.Button btnPayEmployees;
    }
}

