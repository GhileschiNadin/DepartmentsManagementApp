﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class EmployeeService
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

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = null;
            HttpResponseMessage response = client.GetAsync("employee").Result;

            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("gata : " + resultString);
                employees = JsonConvert.DeserializeObject<List<Employee>>(resultString);
                return employees;

            }
            else {
                return null;
            }
        }

        public List<Employee> GetEmployeesPerDepartment(int departmentId) 
        {
            List<Employee> employees = null;
            HttpResponseMessage response = client.GetAsync($"employees/department/{departmentId}").Result;

            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("gata : " + resultString);
                employees = JsonConvert.DeserializeObject<List<Employee>>(resultString);
                return employees;

            }
            else
            {
                return null;
            }
        }

        public List<Employee> GetManagersPerDepartment(int departmentId) 
        {
            List<Employee> employees = null;
            HttpResponseMessage response = client.GetAsync($"managers/{departmentId}").Result;

            if (response.IsSuccessStatusCode)
            {
                string resultString = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("gata : " + resultString);
                employees = JsonConvert.DeserializeObject<List<Employee>>(resultString);
                return employees;

            }
            else
            {
                return null;
            }
        }
    }
 } 

