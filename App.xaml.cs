namespace msanchezTallerS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Vistas.vPrincipal();
            MainPage = new NavigationPage(new Vistas.Vlogin());
        }
    }
}