using MauiApp1.Views;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AñadirContacto), typeof(AñadirContacto));
            Routing.RegisterRoute(nameof(Contacto), typeof(Contacto));
            Routing.RegisterRoute(nameof(EditContacto), typeof(EditContacto)); 
        }
    }
}
