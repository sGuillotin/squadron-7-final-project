namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Declare routing routes for all pages
            Routing.RegisterRoute(nameof(Login), typeof(Login));
            Routing.RegisterRoute(nameof(Signup), typeof(Signup));
            Routing.RegisterRoute(nameof(Menu), typeof(Menu));
            Routing.RegisterRoute(nameof(Cart), typeof(Cart)); 
            Routing.RegisterRoute(nameof(Confirmation), typeof(Confirmation));
            Routing.RegisterRoute(nameof(Orders), typeof(Orders));
        }
    }
}
