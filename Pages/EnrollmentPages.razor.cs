using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd_TAS.Models;
using FrontEnd_TAS.Services;
using Microsoft.AspNetCore.Components;

namespace FrontEnd_TAS.Pages
{
    public partial class EnrollmentPages
    {
         public List<Enrollment> Enrollment { get; set; } = new List<Enrollment>();

        [Inject]
        public IEnrollmentServices EnrollmentServices{ get; set; }
        protected override async Task OnInitializedAsync()
        {
            Enrollment = (await EnrollmentServices.GetAll()).ToList();
        }
    }
}