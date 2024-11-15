using CatalogoArtistas.controller;

namespace CatalogoArtistas.model
{
    internal class Solista : Artista
    {
        private const int TAM_NOMPILA = 20;

        public string NombrePila { get; set; }

        //Constructor
        public Solista(string nombre, int edad, string genero, string nacionalidad, string cancionMasEscuchada, double puntuacion, string nombrePila) : base(nombre, edad, genero, nacionalidad, cancionMasEscuchada, puntuacion)
        {
            this.NombrePila = nombrePila.VerificaTam(TAM_NOMPILA); //Verificar que se guarda con el tamño adecuado
        }

        public Solista(string nombre, int edad, string genero, string nacionalidad, string cancionMasEscuchada, double puntuacion, int id, string nombrePila) : base(nombre, edad, genero, nacionalidad, cancionMasEscuchada, puntuacion, id)
        {
            this.NombrePila = nombrePila.VerificaTam(TAM_NOMPILA); //Verificar que se guarda con el tamño adecuado
            this.Id = id;
        }


        public override string ToString()
        {
            return base.ToString() + $", nombre de pila:{NombrePila.Trim()}";
        }
        
    }
}
