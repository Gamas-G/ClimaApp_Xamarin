using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClimaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();

            this.BindingContext = this;

        }

        /*Esto es interesante si lo colocamos en el constructor en un refresh no carga los datos
         *Con con este metodo y esta lista publica en el xaml lo esta adquiriendo por el binding
         */
        public List<Clima> LisWeather { get => DatosWeather(); }
        private List<Clima> DatosWeather()
        {
            var miLista = new List<Clima>();
            miLista.Add(new Clima() { Dia = "Domingo 21", Temperatura = "27", Icono = "weather" });
            miLista.Add(new Clima() { Dia = "Lunes 22", Temperatura = "29", Icono = "weather" });
            miLista.Add(new Clima() { Dia = "Martes 23", Temperatura = "28", Icono = "weather" });
            miLista.Add(new Clima() { Dia = "Miercoles 24", Temperatura = "28", Icono = "weather" });
            miLista.Add(new Clima() { Dia = "Jueves 25", Temperatura = "28", Icono = "weather" });
            miLista.Add(new Clima() { Dia = "Viernes 26", Temperatura = "28", Icono = "weather" });
            miLista.Add(new Clima() { Dia = "Sábado 27", Temperatura = "29", Icono = "weather" });
            return miLista;
        }

    }

    public class Clima
    {
        public string Dia { set; get; }
        public string Temperatura { set; get; }
        public string Icono { set; get; }
    }
}
