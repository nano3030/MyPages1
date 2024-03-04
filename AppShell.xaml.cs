using MyPages1.Views;

namespace MyPages1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainRecipePage), typeof(MainRecipePage));
            Routing.RegisterRoute(nameof(SalsaPage), typeof(SalsaPage));
            Routing.RegisterRoute(nameof(ChipsPage), typeof(ChipsPage));


        }
    }
}
