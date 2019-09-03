using MasGlobalTest.Common.Settings;
using MasGlobalTest.DAL.Interfaces;
using MasGlobalTest.DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MasGlobalTest.DAL.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        //Injected Settings
        private readonly AppSettings _appSettings;
        private readonly HttpClient _client;


        public EmployeeService(AppSettings appSettings, HttpClient client)
        {
            _appSettings = appSettings;
            _client = client;
        }

        public async Task<List<EmployeeServiceModel>> GetEmployees()
        {
            var httpResponse = await _client.GetAsync(string.Format("{0}{1}", _appSettings.EmployeesApi.BaseUrl, _appSettings.EmployeesApi.Employees));

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve tasks");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<List<EmployeeServiceModel>>(content);

            return tasks;
        }
    }
}
