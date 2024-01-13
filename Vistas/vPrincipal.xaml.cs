namespace jnarvaezts2.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
        InitializeComponent();
        lblUsuario.Text = "BIENVENIDO " + usuario;
    }

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
        string dato = pkEstudiantes.Items[pkEstudiantes.SelectedIndex];
        lblSeleccionado.Text = "Elemento seleccionado es " + dato;
    }

    private void btnParcial1_Clicked(object sender, EventArgs e)
    {
        double nota1 = Convert.ToDouble(txtNota1.Text) * 0.3;
        double nota2 = Convert.ToDouble(txtNota2.Text) * 0.2;
        double notaP1 = nota1 + nota2;

        DisplayAlert("Nota Parcial 1", "Su nota del primer parcial es: " + notaP1, "Cerrar");
    }

    private void btnParcial2_Clicked(object sender, EventArgs e)
    {
        double nota1 = Convert.ToDouble(txtNotaP1.Text) * 0.3;
        double nota2 = Convert.ToDouble(txtNotaP2.Text) * 0.2;
        double notaP2 = nota1 + nota2;

        DisplayAlert("Nota Parcial 2", "Su nota del segundo parcial es: " + notaP2, "Cerrar");
    }

    private void btnNotaFinal_Clicked(object sender, EventArgs e)
    {
        double nota1 = Convert.ToDouble(txtNota1.Text) * 0.3;
        double nota2 = Convert.ToDouble(txtNota2.Text) * 0.2;

        double nota3 = Convert.ToDouble(txtNotaP1.Text) * 0.3;
        double nota4 = Convert.ToDouble(txtNotaP2.Text) * 0.2;
        double notaFinal = nota1 + nota2 + nota3 + nota4 / 4;
        string estado = "";

        if (notaFinal >= 7)
        {
            estado = "Aprobado";
        }
        else if (notaFinal >= 5 && notaFinal <= 6.9)
        {
            estado = "Complementario";
        }
        else
        {
            estado = "Reprobado";
        }

        DisplayAlert("Nota Final", "Su nota final es: " + notaFinal.ToString("0.00") + "\nEstado: " + estado, "Cerrar");
    }
}