using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd_TAS.Models;
using FrontEnd_TAS.Services;
using Microsoft.AspNetCore.Components;

namespace FrontEnd_TAS.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentServices StudentServices { get; set; }

       
        [Inject]
        public NavigationManager NavigationManager { get; set; }



        protected async Task HandleValidSubmit()
        {
            
            var result = await StudentServices.Add(Student);
            NavigationManager.NavigateTo("studentpage"); 
        }
    }
}