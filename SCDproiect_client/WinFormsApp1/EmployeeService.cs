using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace WinFormsApp1
{
    internal class EmployeeService
    {
        static HttpClient client = new HttpClient();


        public void createEmployeeConnection()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:8083/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = null;
            HttpResponseMessage response = client.GetAsync("api/employee/getAll").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                employees = JsonSerializer.Deserialize<List<Employee>>(resultString);
                return employees;

            }
            return null;
        }

        public bool addEmployee(Employee employee)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/employee/create", employee).Result;
            return response.IsSuccessStatusCode;
        }

        public bool updateNameEmployee(Employee employee, int employeeID)
        {
            HttpResponseMessage response = client.PutAsJsonAsync($"api/employee/updateName/{employeeID}", employee).Result;
            return response.IsSuccessStatusCode;
        }

        public bool updateEmailEmployee(Employee employee, int employeeID)
        {
            HttpResponseMessage response = client.PutAsJsonAsync($"api/employee/updateEmail/{employeeID}", employee).Result;
            return response.IsSuccessStatusCode;
        }
        public bool deleteEmployee(int employeeID)
        {
            //HttpResponseMessage response = client.DeleteFromJsonAsync($"api/employee/delete/{employeeID}", employee).Result;
            HttpResponseMessage response = client.DeleteAsync($"api/employee/delete/{employeeID}").Result;
            return response.IsSuccessStatusCode;
        }
        public List<Employee> GetEmployeesFromDepartment(int employeeID)
        {
            List<Employee> employees = null;
            HttpResponseMessage response = client.GetAsync($"api/employee/by-department/{employeeID}").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                employees = JsonSerializer.Deserialize<List<Employee>>(resultString);
                return employees;

            }
            return null;
        }

    }
}

