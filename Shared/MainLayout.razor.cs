namespace Demo_TabsTest.Shared
{
    public partial class MainLayout
    {

        string para_text = "初始值";
        public async Task OnTabClick()
        {
            para_text = "重新赋值";
            await InvokeAsync(StateHasChanged);
        }
    }
}
