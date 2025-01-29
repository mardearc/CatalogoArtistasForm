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

            int max = 0;

            if (listaArtistas.Count > 0)
            {
                max = listaArtistas.Max(artista => artista.Id) + 1;
            }
            int maxImagen = obtenerNumeroMaxImagen("images");

            if (max > maxImagen)
            {
                return max;
            }
            else
            {
                return maxImagen;
            }
        }

        public static int obtenerNumeroMaxImagen(string rutaDirectorio)
        {

            int max = 0;

            // Obtener todos los archivos con extensión .jpg en el directorio
            string[] imagenes = Directory.GetFiles(rutaDirectorio, "*.jpg");

            if (imagenes.Length > 0)
            {
                foreach (string ruta in imagenes)
                {
                    // Obtener el nombre del archivo sin la ruta y sin la extensión
                    string numero = Path.GetFileNameWithoutExtension(ruta);

                    if (numero != "default")
                    {
                        int num = Int32.Parse(numero);

                        // Actualizar el número máximo encontrado
                        if (num > max)
                        {
                            max = num;
                        }

                    }
                }
            }
            // Retornar el siguiente número
            return max + 1;
        }
    }
}
