using BootstrapBlazor.Components;

namespace Demo_TabsTest.Shared
{
    public partial class MainLayout
    {
        string? para_text = "初始值";

        public void OnTabClick()
        {
            para_text = "重新赋值";
            StateHasChanged();
        }

        private Task OnClickTabItemAsync(TabItem item)
        {
            para_text = item.Text;
            StateHasChanged();

            return Task.CompletedTask;
        }
    }
}
