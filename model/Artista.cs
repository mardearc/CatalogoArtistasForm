using CatalogoArtistas.controller;
using System.Globalization;

namespace CatalogoArtistas.model
{
    public class Artista
    {
        //Constantes para el tamaño de los atributos
        private const int TAM_NOMBRE = 20;
        private const int TAM_GENERO = 20;
        private const int TAM_NACIONALIDAD = 20;
        private const int TAM_CANCION = 40;

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public string CancionMasEscuchada { get; set; }
        public double Puntuacion { get; set; }

        //Constructores
        public Artista(string nombre, int edad, string genero, string nacionalidad, string cancionMasEscuchada, double puntuacion)
        {
            //Verificar que se guardan con el tamño adecuado
            this.Nombre = nombre.VerificaTam(TAM_NOMBRE);
            this.Edad = edad;
            this.Genero = genero.VerificaTam(TAM_GENERO);
            this.Nacionalidad = nacionalidad.VerificaTam(TAM_NACIONALIDAD);
            this.CancionMasEscuchada = cancionMasEscuchada.VerificaTam(TAM_CANCION);
            this.Puntuacion = puntuacion;
        }

        public override string ToString()
        {
            return $"Nombre:{Nombre.Trim()}, edad:{Edad}, género:{Genero.Trim()}, nacionalidad:{Nacionalidad.Trim()}" +
                $", canción más escuchada:{CancionMasEscuchada.Trim()}" +
                $", puntuación:{Puntuacion.ToString("F1", CultureInfo.InvariantCulture)}";
        }


    }
}
