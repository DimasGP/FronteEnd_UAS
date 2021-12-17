using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd_TAS.Models;
using FrontEnd_TAS.Services;
using Microsoft.AspNetCore.Components;

namespace FrontEnd_TAS.Pages
{
    public partial class UpdateStudent
    {
        public Student Student { get; set; } = new Student();

          [Inject]
          public IStudentServices StudentServices { get; set; }
          [Inject]
          public NavigationManager NavigationManager { get; set; }
           public List <Student> Students { get; set; } = new List<Student>();
         
          [Parameter]
          public string Id { get; set; }
          
          protected async override Task OnInitializedAsync()
        {
            Student = await StudentServices.GetById(int.Parse(Id));
          
        }

    
        protected async Task HandleValidSubmit(){
            Student result = await StudentServices.Update(int.Parse(Id),Student);
            NavigationManager.NavigateTo("studentpage");
        }
    }
}