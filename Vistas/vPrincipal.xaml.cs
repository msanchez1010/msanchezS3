//using static Android.Provider.ContactsContract.CommonDataKinds;

namespace msanchezTallerS2.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Bienvenido " + usuario;

        //mostrar mensaje emergente de bienvenida
        DisplayAlert("¡Bienvenido/a!", $"Hola, {usuario}", "Aceptar");
    }
    private void txtNotaSeguimiento1_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtNotaSeguimiento1.Text);//10
            if (nota>10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango de 0-10", "Cancelar");
            }
        }
        catch (Exception) 
        {

        }
    }
    private void txtNotaExamen1_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtNotaExamen1.Text);//10
            if (nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango de 0-10", "Cancelar");
            }
        }
        catch (Exception)
        {

        }
    }
    private void txtNotaSeguimiento2_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtNotaSeguimiento2.Text);//10
            if (nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango de 0-10", "Cancelar");
            }
        }
        catch (Exception)
        {

        }
    }
    private void txtNotaExamen2_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double nota = Convert.ToDouble(txtNotaExamen2.Text);//10
            if (nota > 10 || nota < 0)
            {
                DisplayAlert("Alerta", "Rango de 0-10", "Cancelar");
            }
        }
        catch (Exception)
        {

        }
    }

    private void btnClacular_Clicked(object sender, EventArgs e)
    {
        // Calculo nota parcial 1
        double notaSeguimiento1 = double.Parse(txtNotaSeguimiento1.Text);
        double notaExamen1 = double.Parse(txtNotaExamen1.Text);
        
        double final1 =((notaSeguimiento1 * 0.3) + (notaExamen1 * 0.2));
        string formateadoFinal1 = final1.ToString("N2");

        //Calculo nota parcial 2
        double notaSeguimiento2 = double.Parse(txtNotaSeguimiento2.Text);
        double notaExamen2 = double.Parse(txtNotaExamen2.Text);

        double final2 = ((notaSeguimiento2 * 0.3) + (notaExamen2 * 0.2));
        string formateadoFinal2 = final2.ToString("N2");


        //Calculo nota final 
        double notaFinal = final1 + final2;
        string formateadoNotaFinal = notaFinal.ToString("N2");

        // comprobar el estado aprobado, complementario, reprobado
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

        // Mostrar resultado en mensaje ventana emergente
        string mensaje = $"Tu nota final es: {formateadoNotaFinal}\nEstado: {estado}";
        DisplayAlert("Nota Final", mensaje, "Aceptar");
    }
   
}