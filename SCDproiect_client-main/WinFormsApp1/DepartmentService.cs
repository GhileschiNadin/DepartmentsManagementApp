using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DepartmentService
    {
        static HttpClient client = new HttpClient();

        public void createConnection()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:8083/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public List<Department> GetDepartments()
        {
            List<Department> departments = null;
            HttpResponseMessage response = client.GetAsync("department").Result;

            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("gata : " + resultString);
                departments = JsonConvert.DeserializeObject<List<Department>>(resultString);
                return departments;

            }
            else
            {
                return null;
            }
        }
    }
}
