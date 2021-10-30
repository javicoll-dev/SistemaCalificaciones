using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSistemaCalificaciones
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            //datos en los labels
            lblUsuario.Text = usuario;
            
        }

        private void btnCalculo_Clicked(object sender, EventArgs e)
        {
            try 
            {
                //Almacenar datos de parcial 1
                double datoUno = Convert.ToDouble(txtNotaUno.Text);
                double datoDos = Convert.ToDouble(txtNotaDos.Text);

                //operacion parcial 1
                double auxUno = datoUno * 0.3;
                double auxDos = datoDos * 0.2;
                double sumaParcial1 = auxUno + auxDos;

                //Resultado parcial 1
                txtNotaParcialUno.Text = Convert.ToString(sumaParcial1);

                //Almacenar datos de parcial 2
                double datoUnoP = Convert.ToDouble(txtNotaUnoP2.Text);
                double datoDosP = Convert.ToDouble(txtNotaDosP2.Text);

                //operacion parcial 2
                double auxUnoP = datoUnoP * 0.3;
                double auxDosP = datoDosP * 0.2;
                double sumaParcial2 = auxUnoP + auxDosP;

                //Resultado parcial 2
                txtNotaParcialDos.Text = Convert.ToString(sumaParcial2);

                //Resultado nota final
                double notaFinal = sumaParcial1 + sumaParcial2;

                //Resultado nota final
                txtNotaFinalSemestre.Text = Convert.ToString(notaFinal);

                //Verificar estado del alumno
                if (notaFinal >= 7)
                {
                    txtEstado.Text = "Aprobado";
                }
                else
                {
                    if (notaFinal >= 5 && notaFinal <= 6.9)
                    {
                        txtEstado.Text = "Complementario";
                    }
                    else
                    {
                        if (notaFinal < 4.9)
                        {
                            txtEstado.Text = "Reprobado";
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }
        }

        private void txtNotaUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                //comentario
                double datoUno = Convert.ToDouble(txtNotaUno.Text);
                if (datoUno < 0)
                {
                    DisplayAlert("Mensaje de error", "Ingresar una nota mayor a 0", "OK");
                }
                else {
                    if (datoUno > 10) 
                    {
                        DisplayAlert("Mensaje de error", "Ingresar una nota menor a 10", "OK");
                    }
                }
            }
            catch(Exception ex) 
            { 
                
            }
        }

        private void txtNotaDos_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double datoDos = Convert.ToDouble(txtNotaDos.Text);
                if (datoDos < 0)
                {
                    DisplayAlert("Mensaje de error", "Ingresar una nota mayor a 0", "OK");
                }
                else
                {
                    if (datoDos > 10)
                    {
                        DisplayAlert("Mensaje de error", "Ingresar una nota menor a 10", "OK");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNotaUnoP2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double datoUnoP2 = Convert.ToDouble(txtNotaUnoP2.Text);
                if (datoUnoP2 < 0)
                {
                    DisplayAlert("Mensaje de error", "Ingresar una nota mayor a 0", "OK");
                }
                else
                {
                    if (datoUnoP2 > 10)
                    {
                        DisplayAlert("Mensaje de error", "Ingresar una nota menor a 10", "OK");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNotaDosP2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double datoDosP2 = Convert.ToDouble(txtNotaDosP2.Text);
                if (datoDosP2 < 0)
                {
                    DisplayAlert("Mensaje de error", "Ingresar una nota mayor a 0", "OK");
                }
                else
                {
                    if (datoDosP2 > 10)
                    {
                        DisplayAlert("Mensaje de error", "Ingresar una nota menor a 10", "OK");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
