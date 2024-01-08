namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        EmployeeService employeeService;
        List<Employee> employeeList;
        DepartmentService departmentService;
        List<Department> departmentList;
        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employeeService.createEmployeeConnection();
            departmentService = new DepartmentService();
            departmentService.createDepartmentConnection();

        }

        private void getAllEmployees_btn_Click(object sender, EventArgs e)
        {
            employeesList.Items.Clear();
            employeeList = employeeService.GetEmployees();
            foreach (Employee employee in employeeList)
            {
                employeesList.Items.Add(employee.name + "-" + employee.id);
            }
        }

        private void createEmployee_btn_Click(object sender, EventArgs e)
        {
            String employeeName = employeeNameTxt.Text;
            int employeeDepartmentID = Int32.Parse(employeeDepartmentIDTxt.Text);
            String employeeEmail = employeeEmailTxt.Text;
            int employeeManagerID = Int32.Parse(employeeManagerIDTxt.Text);

            Employee newEmployee = new Employee();
            newEmployee.name = employeeName;
            newEmployee.departmentID = employeeDepartmentID;
            newEmployee.email = employeeEmail;
            newEmployee.managerId = employeeManagerID;
            employeeService.addEmployee(newEmployee);
        }

        private void updateEmployeeName_btn_Click(object sender, EventArgs e)
        {

            int employeeID = Int32.Parse(employeeNameUpdateIDTxt.Text);
            String employeeName = employeeNameUpdateTxt.Text;

            Employee updatedEmployee = new Employee();

            updatedEmployee.name = employeeName;
            employeeService.updateNameEmployee(updatedEmployee, employeeID);



        }

        private void updateEmployeeEmail_btn_Click(object sender, EventArgs e)
        {
            int employeeID = Int32.Parse(employeeEmailUpdateIDTxt.Text);
            String employeeEmail = employeeEmailUpdateTxt.Text;

            Employee updatedEmployee = new Employee();

            updatedEmployee.email = employeeEmail;
            employeeService.updateEmailEmployee(updatedEmployee, employeeID);

        }

        private void deleteEmployee_btn_Click(object sender, EventArgs e)
        {
            int employeeID = Int32.Parse(employeeDeleteIDTxt.Text);
            employeeService.deleteEmployee(employeeID);
        }

        private void getAllDepartments_btn_Click(object sender, EventArgs e)
        {
            departmentsList.Items.Clear();
            departmentList = departmentService.getDepartments();
            foreach (Department department in departmentList)
            {
                departmentsList.Items.Add(department.description + "-" + department.id);
            }
        }

        private void createNewDepartment_btn_Click(object sender, EventArgs e)
        {
            String departmentDescription = departmentDescriptionTxt.Text;
            int departmentManagerID = Int32.Parse(departmentManagerIDTxt.Text);
            int departmentParentID = Int32.Parse(departmentParentIDTxt.Text);

            Department newDepartment = new Department();
            newDepartment.description = departmentDescription;
            newDepartment.managerID = departmentManagerID;
            newDepartment.parentID = departmentParentID;
            departmentService.addDepartment(newDepartment);

        }

        private void updateDepartmentName_ID_Click(object sender, EventArgs e)
        {
            int departmentID = Int32.Parse(departmentDescriptionUpdateIDTxt.Text);
            String departmentDescription = departmentDescriptionUpdateTxt.Text;

            Department updatedDepartment = new Department();

            updatedDepartment.description = departmentDescription;
            departmentService.updateDescriptionDepartment(updatedDepartment, departmentID);

        }

        private void deleteDepartment_btn_Click(object sender, EventArgs e)
        {
            int departmentID = Int32.Parse(departmentDeleteTxt.Text);
            departmentService.deleteDepartment(departmentID);
        }

        private void employeesFromDepartment_Click(object sender, EventArgs e)
        {
            int result=0;
            int depID=2;
            if(Int32.TryParse(employeesFromDepartmentList.Text, out result))
            {
                depID = result;
            }

            employeesFromDepartmentList.Items.Clear();
            employeeList = employeeService.GetEmployeesFromDepartment(depID);
            foreach (Employee employee in employeeList)
            {
                employeesFromDepartmentList.Items.Add(employee.name + "-" + employee.id);
            }
        }
    }
}