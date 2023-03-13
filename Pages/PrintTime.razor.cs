using Microsoft.AspNetCore.Components;

namespace Demo_TabsTest.Pages
{
    public partial class PrintTime
    {
        [Parameter]
        public string text { get; set; }


        DateTime currentTime = DateTime.Now;
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            currentTime = DateTime.Now;
        }
    }
}
