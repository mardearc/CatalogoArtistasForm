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

        public static bool CompruebaEdad(string entero)

        {
            bool esCorrecto = false;
            if (Int32.TryParse(entero, out int numero))
            {
                if (numero > 0)
                {
                    esCorrecto = true;
                }

            }
            else
            {
                Console.WriteLine("Entrada inválida, por favor, introduzca una edad");
            }

            return esCorrecto;
        }

        public static bool CompruebaPuntuacion(string puntuacion)

        {
            bool esCorrecto = false;
            if (Int32.TryParse(puntuacion, out int numero))
            {
                if (numero > 0)
                {
                    esCorrecto = true;
                }

            }
            else
            {
                Console.WriteLine("Entrada inválida, por favor, introduzca una edad");
            }

            return esCorrecto;
        }
    }
}
