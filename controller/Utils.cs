using CatalogoArtistas.model;

namespace CatalogoArtistas.controller
{
    public static partial class Utils
    {

        //Método para verificar el tamaño de los atributos de tipo string
        public static string VerificaTam(this string valor, int tam)
        {
            if (valor.Length > tam) //Si el tamaño es mayor lo trunca
            {
                valor = valor.Substring(0, tam);
            }
            else
            {
                valor = valor.PadRight(tam); //Si el tamaño es menor rellena con espacios
            }

            return valor;
        }

        //Método para verificar si se puede leer un artista al completo
        public static bool SePuedenLeer(this BinaryReader br, int numBytes)
        {
            bool sePuede = false;
            if (br != null)
            {
                sePuede = br.BaseStream.Length - br.BaseStream.Position >= numBytes;
            }
            return sePuede;
        }


        //Genera un nuevo Id tomando como referencia el Id más alto existente
        public static int GenerarNuevoId()
        {
            CtrlArtista ctrlArtista = CtrlArtista.GetControlador();
            List<Artista> listaArtistas = ctrlArtista.ConsultarDatos();

            if (listaArtistas.Count == 0)
            {
                return 1; // Si la lista está vacía, el primer ID será 1
            }

            return listaArtistas.Max(artista => artista.Id) + 1; // Incrementa el ID más alto
        }
    }
}
