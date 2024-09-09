using System;
using Microsoft.AspNetCore.Components;

namespace Demo
{
    public partial class Spinner
    {

        [Parameter]
        public string Message { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }
    }
}

