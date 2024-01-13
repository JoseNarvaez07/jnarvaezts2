namespace jnarvaezts2.Vistas;

public partial class vLogin : ContentPage
{
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };
    public vLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContraseña.Text;


        int index = Array.IndexOf(users, usuarioIngresado);
        if (index != -1 && passwords[index] == contrasenaIngresada)
        {

            string nombreUsuarioConectado = users[index];
            DisplayAlert("Bienvenido", $"¡Hola {nombreUsuarioConectado}!", "Aceptar");


            Navigation.PushAsync(new vPrincipal(nombreUsuarioConectado));
        }
        else
        {

            DisplayAlert("ALERTA", "Usuario/Contraseña incorrectos", "Cancelar");
        }
    }
}