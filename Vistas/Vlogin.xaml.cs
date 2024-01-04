namespace msanchezTallerS2.Vistas;

public partial class Vlogin : ContentPage
{  
    private string[] usuarios = { "Carlos", "Ana", "Jose", "Moises" };
    private string[] contrasenas = { "carlos123", "ana123", "jose123", "moises1010" };

    public Vlogin()
    {
        InitializeComponent();
    }

    private async void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContrasena.Text;

        // Busca el usuario en el array
        int index = Array.IndexOf(usuarios, usuarioIngresado);

        if (index != -1 && contrasenaIngresada == contrasenas[index])
        {
            await Navigation.PushAsync(new vPrincipal(usuarioIngresado));
        }
        else
        {
            await DisplayAlert("ALERTA", "Usuario o Contraseña incorrecto", "Cancelar");
        }
    }
}
    //Misma utilidad del sistema envez de vectores se utiliza Dictionary

/*private Dictionary<string, string> usuarios = new Dictionary<string, string>
   {
       { "Carlos", "carlos123" },
       { "Ana", "ana123" },
       { "Jose", "jose123" },
       { "Moises", "moises1010" }
   };

   public Vlogin()
   {
       InitializeComponent();
   }

   private async void btnIniciar_Clicked(object sender, EventArgs e)
   {
       string usuarioIngresado = txtUsuario.Text;
       string contrasenaIngresada = txtContrasena.Text;


       if (usuarios.TryGetValue(usuarioIngresado, out string contrasenaCorrecta) && contrasenaIngresada == contrasenaCorrecta)
       {
           //navegacion a la ventana principal
           await Navigation.PushAsync(new vPrincipal(usuarioIngresado));
       }
       else
       {
           await DisplayAlert("ALERTA", "Usuario o Contraseña incorrecto", "Cancelar");
       }
   }
   */