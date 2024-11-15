using CatalogoArtistas.controller;

namespace CatalogoArtistas.model
{
    internal class DeGrupo : Artista
    {
        private const int TAM_NOMGRUPO = 20;
        public string NombreGrupo {  get; set; }


        //Constructor
        public DeGrupo(string nombre, int edad, string genero, string nacionalidad, string cancionMasEscuchada, double puntuacion, string nombreGrupo) : base(nombre, edad, genero, nacionalidad, cancionMasEscuchada, puntuacion)
        {
            this.NombreGrupo = nombreGrupo.VerificaTam(TAM_NOMGRUPO); //Verificar que se guarda con el tamño adecuado
        }
        public DeGrupo(string nombre, int edad, string genero, string nacionalidad, string cancionMasEscuchada, double puntuacion, int id, string nombreGrupo) : base(nombre, edad, genero, nacionalidad, cancionMasEscuchada, puntuacion, id)
        {
            this.NombreGrupo = nombreGrupo.VerificaTam(TAM_NOMGRUPO); //Verificar que se guarda con el tamño adecuado
        }

        public override string ToString()
        {
            return base.ToString() + $", nombre de grupo:{NombreGrupo.Trim()}";
        }

    }
}
