using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FrontEnd_TAS.Models;

namespace FrontEnd_TAS.Services
{
    public class EnrollmentServices : IEnrollmentServices
    {
        private HttpClient _httpClient;
        public EnrollmentServices(HttpClient httpClient) 
        {
         _httpClient = httpClient;
        }

        public async Task<IEnumerable<Enrollment>> GetAll()
        {
           var results = await _httpClient.GetFromJsonAsync<IEnumerable<Enrollment>>("api/Enrollment");
           return results;
        }

        public async Task<Enrollment> GetById(int id)
        {
           var result = await _httpClient.GetFromJsonAsync<Enrollment>($"api/Enrollment/{id}");
           return result;
        }
    }
}