using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DepartmentService
    {
        static HttpClient client = new HttpClient();

        public void createDepartmentConnection()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:8083/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public List<Department> getDepartments()
        {
            List<Department> departments = null;
            HttpResponseMessage response = client.GetAsync("api/department/getAll").Result;
            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                departments = JsonSerializer.Deserialize<List<Department>>(resultString);
                return departments;

            }
            return null;

        }

        public bool addDepartment(Department department)
        {
            HttpResponseMessage response = client.PostAsJsonAsync("api/department/create", department).Result;
            return response.IsSuccessStatusCode;
        }

        public bool updateDescriptionDepartment(Department department, int departmentID)
        {
            HttpResponseMessage response = client.PutAsJsonAsync($"api/department/update/{departmentID}", department).Result;
            return response.IsSuccessStatusCode;
        }
        public bool deleteDepartment(int departmentID)
        {
            HttpResponseMessage response = client.DeleteAsync($"api/department/update/ {departmentID}").Result;
            return response.IsSuccessStatusCode;
        }
    }
}
