using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using xamarinStudentApp.models;

namespace xamarinStudentApp
{
    public class HttpService
    {
        HttpClient client;

        public HttpService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7081");
        }

        public async Task<List<Student>> getStudents()
        {
            return JsonConvert.DeserializeObject<List<Student>>(await client.GetStringAsync("/api/Student"));
        }
    }
}
