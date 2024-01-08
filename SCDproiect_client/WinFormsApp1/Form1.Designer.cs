namespace WinFormsApp1
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
            label1 = new Label();
            getAllEmployees_btn = new Button();
            employeesList = new ListBox();
            label2 = new Label();
            employeeNameTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            employeeDepartmentIDTxt = new TextBox();
            employeeEmailTxt = new TextBox();
            employeeManagerIDTxt = new TextBox();
            label7 = new Label();
            label8 = new Label();
            employeeNameUpdateIDTxt = new TextBox();
            label9 = new Label();
            employeeNameUpdateTxt = new TextBox();
            label10 = new Label();
            employeeEmailUpdateIDTxt = new TextBox();
            label12 = new Label();
            employeeEmailUpdateTxt = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label14 = new Label();
            employeeDeleteIDTxt = new TextBox();
            departmentParentIDTxt = new TextBox();
            departmentManagerIDTxt = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            departmentDescriptionTxt = new TextBox();
            label19 = new Label();
            label20 = new Label();
            departmentsList = new ListBox();
            getAllDepartments_btn = new Button();
            departmentDeleteTxt = new TextBox();
            label15 = new Label();
            label21 = new Label();
            departmentDescriptionUpdateTxt = new TextBox();
            label25 = new Label();
            departmentDescriptionUpdateIDTxt = new TextBox();
            label26 = new Label();
            label27 = new Label();
            createEmployee_btn = new Button();
            deleteEmployee_btn = new Button();
            updateEmployeeName_btn = new Button();
            updateEmployeeEmail_btn = new Button();
            createNewDepartment_btn = new Button();
            updateDepartmentName_ID = new Button();
            deleteDepartment_btn = new Button();
            label22 = new Label();
            employeesFromDepartmentList = new ListBox();
            label23 = new Label();
            employeesDepartmentID = new TextBox();
            employeesFromDepartment = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(28, 327);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 1;
            label1.Text = "Create new employee";
            // 
            // getAllEmployees_btn
            // 
            getAllEmployees_btn.Location = new Point(28, 272);
            getAllEmployees_btn.Margin = new Padding(3, 2, 3, 2);
            getAllEmployees_btn.Name = "getAllEmployees_btn";
            getAllEmployees_btn.Size = new Size(161, 22);
            getAllEmployees_btn.TabIndex = 2;
            getAllEmployees_btn.Text = "Load Employees";
            getAllEmployees_btn.UseVisualStyleBackColor = true;
            getAllEmployees_btn.Click += getAllEmployees_btn_Click;
            // 
            // employeesList
            // 
            employeesList.FormattingEnabled = true;
            employeesList.ItemHeight = 15;
            employeesList.Location = new Point(32, 56);
            employeesList.Name = "employeesList";
            employeesList.Size = new Size(157, 199);
            employeesList.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(32, 23);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 4;
            label2.Text = "Employees";
            // 
            // employeeNameTxt
            // 
            employeeNameTxt.Location = new Point(122, 356);
            employeeNameTxt.Name = "employeeNameTxt";
            employeeNameTxt.Size = new Size(100, 23);
            employeeNameTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 364);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 393);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "DepartmentID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 422);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 8;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 452);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 9;
            label6.Text = "ManagerID:";
            // 
            // employeeDepartmentIDTxt
            // 
            employeeDepartmentIDTxt.Location = new Point(122, 385);
            employeeDepartmentIDTxt.Name = "employeeDepartmentIDTxt";
            employeeDepartmentIDTxt.Size = new Size(100, 23);
            employeeDepartmentIDTxt.TabIndex = 10;
            // 
            // employeeEmailTxt
            // 
            employeeEmailTxt.Location = new Point(122, 414);
            employeeEmailTxt.Name = "employeeEmailTxt";
            employeeEmailTxt.Size = new Size(100, 23);
            employeeEmailTxt.TabIndex = 11;
            // 
            // employeeManagerIDTxt
            // 
            employeeManagerIDTxt.Location = new Point(122, 444);
            employeeManagerIDTxt.Name = "employeeManagerIDTxt";
            employeeManagerIDTxt.Size = new Size(100, 23);
            employeeManagerIDTxt.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(364, 23);
            label7.Name = "label7";
            label7.Size = new Size(143, 17);
            label7.TabIndex = 13;
            label7.Text = "Update employee's name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 66);
            label8.Name = "label8";
            label8.Size = new Size(21, 15);
            label8.TabIndex = 14;
            label8.Text = "ID:";
            // 
            // employeeNameUpdateIDTxt
            // 
            employeeNameUpdateIDTxt.Location = new Point(447, 58);
            employeeNameUpdateIDTxt.Name = "employeeNameUpdateIDTxt";
            employeeNameUpdateIDTxt.Size = new Size(100, 23);
            employeeNameUpdateIDTxt.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(364, 90);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 16;
            label9.Text = "New name:";
            // 
            // employeeNameUpdateTxt
            // 
            employeeNameUpdateTxt.Location = new Point(447, 87);
            employeeNameUpdateTxt.Name = "employeeNameUpdateTxt";
            employeeNameUpdateTxt.Size = new Size(100, 23);
            employeeNameUpdateTxt.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(364, 197);
            label10.Name = "label10";
            label10.Size = new Size(142, 17);
            label10.TabIndex = 18;
            label10.Text = "Update employee's email";
            // 
            // employeeEmailUpdateIDTxt
            // 
            employeeEmailUpdateIDTxt.Location = new Point(447, 237);
            employeeEmailUpdateIDTxt.Name = "employeeEmailUpdateIDTxt";
            employeeEmailUpdateIDTxt.Size = new Size(100, 23);
            employeeEmailUpdateIDTxt.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(365, 276);
            label12.Name = "label12";
            label12.Size = new Size(66, 15);
            label12.TabIndex = 21;
            label12.Text = "New email:";
            // 
            // employeeEmailUpdateTxt
            // 
            employeeEmailUpdateTxt.Location = new Point(447, 276);
            employeeEmailUpdateTxt.Name = "employeeEmailUpdateTxt";
            employeeEmailUpdateTxt.Size = new Size(100, 23);
            employeeEmailUpdateTxt.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Location = new Point(364, 385);
            label13.Name = "label13";
            label13.Size = new Size(97, 17);
            label13.TabIndex = 23;
            label13.Text = "Delete employee";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(364, 240);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 19;
            label11.Text = "ID:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(365, 422);
            label14.Name = "label14";
            label14.Size = new Size(21, 15);
            label14.TabIndex = 24;
            label14.Text = "ID:";
            // 
            // employeeDeleteIDTxt
            // 
            employeeDeleteIDTxt.Location = new Point(447, 419);
            employeeDeleteIDTxt.Name = "employeeDeleteIDTxt";
            employeeDeleteIDTxt.Size = new Size(100, 23);
            employeeDeleteIDTxt.TabIndex = 25;
            // 
            // departmentParentIDTxt
            // 
            departmentParentIDTxt.Location = new Point(827, 419);
            departmentParentIDTxt.Name = "departmentParentIDTxt";
            departmentParentIDTxt.Size = new Size(100, 23);
            departmentParentIDTxt.TabIndex = 33;
            // 
            // departmentManagerIDTxt
            // 
            departmentManagerIDTxt.Location = new Point(827, 390);
            departmentManagerIDTxt.Name = "departmentManagerIDTxt";
            departmentManagerIDTxt.Size = new Size(100, 23);
            departmentManagerIDTxt.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(740, 427);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 30;
            label16.Text = "ParentID:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(737, 398);
            label17.Name = "label17";
            label17.Size = new Size(68, 15);
            label17.TabIndex = 29;
            label17.Text = "ManagerID:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(740, 369);
            label18.Name = "label18";
            label18.Size = new Size(70, 15);
            label18.TabIndex = 28;
            label18.Text = "Description:";
            // 
            // departmentDescriptionTxt
            // 
            departmentDescriptionTxt.Location = new Point(827, 361);
            departmentDescriptionTxt.Name = "departmentDescriptionTxt";
            departmentDescriptionTxt.Size = new Size(100, 23);
            departmentDescriptionTxt.TabIndex = 27;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Location = new Point(740, 327);
            label19.Name = "label19";
            label19.Size = new Size(133, 17);
            label19.TabIndex = 26;
            label19.Text = "Create new department";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BorderStyle = BorderStyle.Fixed3D;
            label20.Location = new Point(733, 23);
            label20.Name = "label20";
            label20.Size = new Size(72, 17);
            label20.TabIndex = 37;
            label20.Text = "Department";
            // 
            // departmentsList
            // 
            departmentsList.FormattingEnabled = true;
            departmentsList.ItemHeight = 15;
            departmentsList.Location = new Point(729, 56);
            departmentsList.Name = "departmentsList";
            departmentsList.Size = new Size(157, 199);
            departmentsList.TabIndex = 36;
            // 
            // getAllDepartments_btn
            // 
            getAllDepartments_btn.Location = new Point(729, 272);
            getAllDepartments_btn.Margin = new Padding(3, 2, 3, 2);
            getAllDepartments_btn.Name = "getAllDepartments_btn";
            getAllDepartments_btn.Size = new Size(161, 22);
            getAllDepartments_btn.TabIndex = 35;
            getAllDepartments_btn.Text = "Load Departments";
            getAllDepartments_btn.UseVisualStyleBackColor = true;
            getAllDepartments_btn.Click += getAllDepartments_btn_Click;
            // 
            // departmentDeleteTxt
            // 
            departmentDeleteTxt.Location = new Point(1100, 216);
            departmentDeleteTxt.Name = "departmentDeleteTxt";
            departmentDeleteTxt.Size = new Size(100, 23);
            departmentDeleteTxt.TabIndex = 50;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1000, 219);
            label15.Name = "label15";
            label15.Size = new Size(21, 15);
            label15.TabIndex = 49;
            label15.Text = "ID:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Location = new Point(999, 187);
            label21.Name = "label21";
            label21.Size = new Size(107, 17);
            label21.TabIndex = 48;
            label21.Text = "Delete department";
            // 
            // departmentDescriptionUpdateTxt
            // 
            departmentDescriptionUpdateTxt.Location = new Point(1101, 87);
            departmentDescriptionUpdateTxt.Name = "departmentDescriptionUpdateTxt";
            departmentDescriptionUpdateTxt.Size = new Size(100, 23);
            departmentDescriptionUpdateTxt.TabIndex = 42;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(998, 95);
            label25.Name = "label25";
            label25.Size = new Size(96, 15);
            label25.TabIndex = 41;
            label25.Text = "New description:";
            // 
            // departmentDescriptionUpdateIDTxt
            // 
            departmentDescriptionUpdateIDTxt.Location = new Point(1101, 58);
            departmentDescriptionUpdateIDTxt.Name = "departmentDescriptionUpdateIDTxt";
            departmentDescriptionUpdateIDTxt.Size = new Size(100, 23);
            departmentDescriptionUpdateIDTxt.TabIndex = 40;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(999, 66);
            label26.Name = "label26";
            label26.Size = new Size(21, 15);
            label26.TabIndex = 39;
            label26.Text = "ID:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BorderStyle = BorderStyle.Fixed3D;
            label27.Location = new Point(999, 23);
            label27.Name = "label27";
            label27.Size = new Size(182, 17);
            label27.TabIndex = 38;
            label27.Text = "Update department's description";
            // 
            // createEmployee_btn
            // 
            createEmployee_btn.Location = new Point(35, 485);
            createEmployee_btn.Name = "createEmployee_btn";
            createEmployee_btn.Size = new Size(75, 23);
            createEmployee_btn.TabIndex = 51;
            createEmployee_btn.Text = "Create";
            createEmployee_btn.UseVisualStyleBackColor = true;
            createEmployee_btn.Click += createEmployee_btn_Click;
            // 
            // deleteEmployee_btn
            // 
            deleteEmployee_btn.Location = new Point(364, 452);
            deleteEmployee_btn.Name = "deleteEmployee_btn";
            deleteEmployee_btn.Size = new Size(75, 23);
            deleteEmployee_btn.TabIndex = 52;
            deleteEmployee_btn.Text = "Delete";
            deleteEmployee_btn.UseVisualStyleBackColor = true;
            deleteEmployee_btn.Click += deleteEmployee_btn_Click;
            // 
            // updateEmployeeName_btn
            // 
            updateEmployeeName_btn.Location = new Point(364, 123);
            updateEmployeeName_btn.Name = "updateEmployeeName_btn";
            updateEmployeeName_btn.Size = new Size(75, 23);
            updateEmployeeName_btn.TabIndex = 53;
            updateEmployeeName_btn.Text = "Update";
            updateEmployeeName_btn.UseVisualStyleBackColor = true;
            updateEmployeeName_btn.Click += updateEmployeeName_btn_Click;
            // 
            // updateEmployeeEmail_btn
            // 
            updateEmployeeEmail_btn.Location = new Point(364, 310);
            updateEmployeeEmail_btn.Name = "updateEmployeeEmail_btn";
            updateEmployeeEmail_btn.Size = new Size(75, 23);
            updateEmployeeEmail_btn.TabIndex = 54;
            updateEmployeeEmail_btn.Text = "Update";
            updateEmployeeEmail_btn.UseVisualStyleBackColor = true;
            updateEmployeeEmail_btn.Click += updateEmployeeEmail_btn_Click;
            // 
            // createNewDepartment_btn
            // 
            createNewDepartment_btn.Location = new Point(740, 452);
            createNewDepartment_btn.Name = "createNewDepartment_btn";
            createNewDepartment_btn.Size = new Size(75, 23);
            createNewDepartment_btn.TabIndex = 55;
            createNewDepartment_btn.Text = "Create";
            createNewDepartment_btn.UseVisualStyleBackColor = true;
            createNewDepartment_btn.Click += createNewDepartment_btn_Click;
            // 
            // updateDepartmentName_ID
            // 
            updateDepartmentName_ID.Location = new Point(999, 132);
            updateDepartmentName_ID.Name = "updateDepartmentName_ID";
            updateDepartmentName_ID.Size = new Size(75, 23);
            updateDepartmentName_ID.TabIndex = 56;
            updateDepartmentName_ID.Text = "Update";
            updateDepartmentName_ID.UseVisualStyleBackColor = true;
            updateDepartmentName_ID.Click += updateDepartmentName_ID_Click;
            // 
            // deleteDepartment_btn
            // 
            deleteDepartment_btn.Location = new Point(999, 261);
            deleteDepartment_btn.Name = "deleteDepartment_btn";
            deleteDepartment_btn.Size = new Size(75, 23);
            deleteDepartment_btn.TabIndex = 58;
            deleteDepartment_btn.Text = "Delete";
            deleteDepartment_btn.UseVisualStyleBackColor = true;
            deleteDepartment_btn.Click += deleteDepartment_btn_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BorderStyle = BorderStyle.Fixed3D;
            label22.Location = new Point(998, 327);
            label22.Name = "label22";
            label22.Size = new Size(181, 17);
            label22.TabIndex = 59;
            label22.Text = "Get employees from department";
            // 
            // employeesFromDepartmentList
            // 
            employeesFromDepartmentList.FormattingEnabled = true;
            employeesFromDepartmentList.ItemHeight = 15;
            employeesFromDepartmentList.Location = new Point(998, 414);
            employeesFromDepartmentList.Name = "employeesFromDepartmentList";
            employeesFromDepartmentList.Size = new Size(225, 199);
            employeesFromDepartmentList.TabIndex = 60;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(998, 369);
            label23.Name = "label23";
            label23.Size = new Size(84, 15);
            label23.TabIndex = 61;
            label23.Text = "DepartmentID:";
            // 
            // employeesDepartmentID
            // 
            employeesDepartmentID.Location = new Point(1088, 364);
            employeesDepartmentID.Name = "employeesDepartmentID";
            employeesDepartmentID.Size = new Size(100, 23);
            employeesDepartmentID.TabIndex = 62;
            // 
            // employeesFromDepartment
            // 
            employeesFromDepartment.Location = new Point(1000, 623);
            employeesFromDepartment.Margin = new Padding(3, 2, 3, 2);
            employeesFromDepartment.Name = "employeesFromDepartment";
            employeesFromDepartment.Size = new Size(161, 22);
            employeesFromDepartment.TabIndex = 63;
            employeesFromDepartment.Text = "Load Employees";
            employeesFromDepartment.UseVisualStyleBackColor = true;
            employeesFromDepartment.Click += employeesFromDepartment_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 656);
            Controls.Add(employeesFromDepartment);
            Controls.Add(employeesDepartmentID);
            Controls.Add(label23);
            Controls.Add(employeesFromDepartmentList);
            Controls.Add(label22);
            Controls.Add(deleteDepartment_btn);
            Controls.Add(updateDepartmentName_ID);
            Controls.Add(createNewDepartment_btn);
            Controls.Add(updateEmployeeEmail_btn);
            Controls.Add(updateEmployeeName_btn);
            Controls.Add(deleteEmployee_btn);
            Controls.Add(createEmployee_btn);
            Controls.Add(departmentDeleteTxt);
            Controls.Add(label15);
            Controls.Add(label21);
            Controls.Add(departmentDescriptionUpdateTxt);
            Controls.Add(label25);
            Controls.Add(departmentDescriptionUpdateIDTxt);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(label20);
            Controls.Add(departmentsList);
            Controls.Add(getAllDepartments_btn);
            Controls.Add(departmentParentIDTxt);
            Controls.Add(departmentManagerIDTxt);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(departmentDescriptionTxt);
            Controls.Add(label19);
            Controls.Add(employeeDeleteIDTxt);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(employeeEmailUpdateTxt);
            Controls.Add(label12);
            Controls.Add(employeeEmailUpdateIDTxt);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(employeeNameUpdateTxt);
            Controls.Add(label9);
            Controls.Add(employeeNameUpdateIDTxt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(employeeManagerIDTxt);
            Controls.Add(employeeEmailTxt);
            Controls.Add(employeeDepartmentIDTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(employeeNameTxt);
            Controls.Add(label2);
            Controls.Add(employeesList);
            Controls.Add(getAllEmployees_btn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button getAllEmployees_btn;
        private ListBox employeesList;
        private Label label2;
        private TextBox employeeNameTxt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox employeeDepartmentIDTxt;
        private TextBox employeeEmailTxt;
        private TextBox employeeManagerIDTxt;
        private Label label7;
        private Label label8;
        private TextBox employeeNameUpdateIDTxt;
        private Label label9;
        private TextBox employeeNameUpdateTxt;
        private Label label10;
        private TextBox employeeEmailUpdateIDTxt;
        private Label label12;
        private TextBox employeeEmailUpdateTxt;
        private Label label13;
        private Label label11;
        private Label label14;
        private TextBox employeeDeleteIDTxt;
        private TextBox departmentParentIDTxt;
        private TextBox departmentManagerIDTxt;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox departmentDescriptionTxt;
        private Label label19;
        private Label label20;
        private ListBox departmentsList;
        private Button getAllDepartments_btn;
        private TextBox departmentDeleteTxt;
        private Label label15;
        private Label label21;
        private TextBox departmentDescriptionUpdateTxt;
        private Label label25;
        private TextBox departmentDescriptionUpdateIDTxt;
        private Label label26;
        private Label label27;
        private Button createEmployee_btn;
        private Button deleteEmployee_btn;
        private Button updateEmployeeName_btn;
        private Button updateEmployeeEmail_btn;
        private Button createNewDepartment_btn;
        private Button updateDepartmentName_ID;
        private Button deleteDepartment_btn;
        private Label label22;
        private ListBox employeesFromDepartmentList;
        private Label label23;
        private TextBox employeesDepartmentID;
        private Button employeesFromDepartment;
    }
}