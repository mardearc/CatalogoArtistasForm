using CatalogoArtistas.model;

namespace CatalogoArtistas.controller
{
    internal class CtrlArtista
    {
        private static string Fichero = "artistas.dat"; //Ruta del fichero

        private List<Artista> Artistas = new List<Artista>();


        private static CtrlArtista mi_controlador;
        
        private const int BYTES_ARTISTA = 141;
        
        private CtrlArtista() { }

        //Inicializar controlador
        public static CtrlArtista GetControlador()
        {

            if (mi_controlador == null)
            {
                mi_controlador = new CtrlArtista();
            }
            return mi_controlador;
        }

        //Método para cargar los datos desde el fichero
        public void CargarDatos(string ruta = null)
        {

            if (ruta != null)
            {
                Fichero = ruta;
            }
            
            Artistas.Clear();

            try
            {
                using (FileStream fs = new FileStream(Fichero, FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length - sizeof(char))
                    {
                        char primerCaracter = br.ReadChar();

                        if (br.SePuedenLeer(BYTES_ARTISTA)) //Si se puede leer un nuevo artista se continúa
                        {
                            if (primerCaracter == 'G')
                            {

                                string Nombre = br.ReadString();
                                int Edad = br.ReadInt32();
                                string Genero = br.ReadString();
                                string Nacionalidad = br.ReadString();
                                string CancionMasEscuchada = br.ReadString();
                                double Puntuacion = br.ReadDouble();
                                int Id = br.ReadInt32();
                                string NombreGrupo = br.ReadString();
                                

                                DeGrupo deGrupo = new DeGrupo(Nombre,Edad,Genero,Nacionalidad,CancionMasEscuchada, Puntuacion, Id, NombreGrupo);
                                Artistas.Add(deGrupo);
                            }
                            else if (primerCaracter == 'S')
                            {
                                string Nombre = br.ReadString();
                                int Edad = br.ReadInt32();
                                string Genero = br.ReadString();
                                string Nacionalidad = br.ReadString();
                                string CancionMasEscuchada = br.ReadString();
                                double Puntuacion = br.ReadDouble();
                                int Id = br.ReadInt32();
                                string NombrePila = br.ReadString();
                                

                                Solista solista = new(Nombre, Edad, Genero,Nacionalidad,CancionMasEscuchada, Puntuacion, Id, NombrePila);
                                Artistas.Add(solista);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //Método para escribir los datos en el fichero
        public void EscribirDatos(string ruta = null)
        {
            if (ruta != null)
            {
                Fichero = ruta;
            }
            if (File.Exists(Fichero))
            {
                DateTime dt = DateTime.Now;
                File.Move(Fichero, $"catalogo_{dt.Day}-{dt.Month}-{dt.Year}-{dt.Ticks}");
            }

            int numGuardados = 0;
            try
            {
                using (FileStream fs = new FileStream(Fichero, FileMode.Create))
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    foreach (var artista in Artistas)
                    {
                        if (artista is DeGrupo deGrupo)
                        {
                            bw.Write('G');
                            bw.Write(deGrupo.Nombre);
                            bw.Write(deGrupo.Edad);
                            bw.Write(deGrupo.Genero);
                            bw.Write(deGrupo.Nacionalidad);
                            bw.Write(deGrupo.CancionMasEscuchada);
                            bw.Write(deGrupo.Puntuacion);
                            bw.Write(deGrupo.Id);
                            bw.Write(deGrupo.NombreGrupo);
                            numGuardados++;
                        }
                        else if (artista is Solista solista)
                        {
                            bw.Write('S');
                            bw.Write(solista.Nombre);
                            bw.Write(solista.Edad);
                            bw.Write(solista.Genero);
                            bw.Write(solista.Nacionalidad);
                            bw.Write(solista.CancionMasEscuchada);
                            bw.Write(solista.Puntuacion);
                            bw.Write(solista.Id);
                            bw.Write(solista.NombrePila);
                            numGuardados++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Error durante el guardado del catálogo. Se han guardado {numGuardados} artistas");
            }
        }

        //Método para añadir un nuevo artista
        public void AddArtista(Artista artista)
        {
            Artistas.Add(artista);
            EscribirDatos();
        }

        //Método para ordenar los artistas segun un dterminado atributo
        public List<Artista> Ordenar(string columna)
        {
            List<Artista> listaOrdenada = new List<Artista>();
            switch (columna)
            {
                case "1":
                    listaOrdenada = Artistas.OrderBy(x => x.Nombre).ToList();
                    break;
                case "2":
                    listaOrdenada = Artistas.OrderBy(x => x.Edad).ToList();
                    break;
                case "3":
                    listaOrdenada = Artistas.OrderBy(x => x.Genero).ToList();
                    break;
                case "4":
                    listaOrdenada = Artistas.OrderBy(x => x.Nacionalidad).ToList();
                    break;
                case "5":
                    listaOrdenada = Artistas.OrderBy(x => x.CancionMasEscuchada).ToList();
                    break;
                case "6":
                    listaOrdenada = Artistas.OrderBy(x => x.Puntuacion).ToList();
                    break;
                default: //Si no elige una opción correcta se le vuelve a preguntar
                    Console.WriteLine("\nColumna incorrecta");
                    Console.WriteLine("Elija la columna por la que desea ordenar" +
                        "\n1->Nombre\n2->Edad\n3->Genero\n4->Nacionalidad\n5->Cancion más escuchada\n6->Puntuación");
                    Ordenar(Console.ReadLine());
                    break;
            }

            foreach (Artista artista in listaOrdenada)
            {
                Console.WriteLine(artista);
            }

            return listaOrdenada;

        }

        //Método para eliminar artistas
        public int EliminarArtista(List<Artista> artistasEliminar)
        {
            //Contador de artistas eliminados
            int cont = 0;

            foreach (Artista artista in artistasEliminar) {
                //Guardar id del artista eliminado
                int id = artista.Id;

                // Elimina la imagen asociada al artista.
                string rutaImagen = $"images/{id}.jpg";
                if (File.Exists(rutaImagen))
                {
                    try
                    {
                        File.Delete(rutaImagen);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se pudo eliminar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Eliminar el artista y sumar el contador
                Artistas.Remove(artista);
                cont++;
            }

            EscribirDatos();
            return cont;
        }

        //Método para listar todos los artistas en el orden introducido
        public List<Artista> ConsultarDatos() => Artistas;

        //Método para filtrar los artistas por uno o más atributos
        public List<Artista> Buscar(int Edad, double Puntuacion, char Tipo, string Nombre = null, string Genero = null, string Nacionalidad = null, string Cancion = null, string NombrePila = null, string NombreGrupo = null)
        {
            List<Artista> listFiltrada = new List<Artista>();

            //Si el nombre no es null se añaden a la lista filtrada aquellos artistas que coincidan con el nombre
            if (Nombre.Trim() != "")
            {
                foreach (Artista art in Artistas)
                {
                    if (art.Nombre.Contains(Nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        listFiltrada.Add(art);
                    }
                }
                if (listFiltrada.Count == 0) //Si la lista está vacía es porque no coincide ningún nombre, se devuelve la lista vacía
                {
                    return listFiltrada;
                }
            }
            //Si la edad es distinta al valor por defecto
            if (Edad != 0)
            {
                if (listFiltrada.Count == 0) //Si la lista filtrada está vacía se añaden los artistas que tengan la edad elegida
                {
                    foreach (Artista art in Artistas)
                    {
                        if (art.Edad == Edad)
                        {
                            listFiltrada.Add(art);
                        }
                    }
                }
                else //Si la lista no está vacía se eliminan los artistas que no tengan esa edad
                {
                    for (int i = listFiltrada.Count - 1; i >= 0; i--)
                    {
                        if (listFiltrada[i].Edad != Edad)
                        {
                            listFiltrada.Remove(listFiltrada[i]);
                        }
                    }
                }
                if (listFiltrada.Count == 0) //Si la lista está vacía es porque no coincide ninguna edad, se devuelve la lista vacía
                {
                    return listFiltrada;
                }
            }
            //Si el genero es distinto a null
            if (Genero.Trim() != "")
            {
                if (listFiltrada.Count == 0)//Si la lista filtrada está vacía se añaden los artistas que tengan el genero elegido
                {
                    foreach (Artista art in Artistas)
                    {
                        if (art.Genero.Contains(Genero, StringComparison.OrdinalIgnoreCase))
                        {
                            listFiltrada.Add(art);
                        }
                    }
                }
                else//Si la lista no está vacía se eliminan los artistas que no tengan ese genero
                {
                    for (int i = listFiltrada.Count - 1; i >= 0; i--)
                    {
                        if (!listFiltrada[i].Genero.Contains(Genero, StringComparison.OrdinalIgnoreCase))
                        {
                            listFiltrada.Remove(listFiltrada[i]);
                        }
                    }
                }
                if (listFiltrada.Count == 0) //Si la lista está vacía es porque no coincide ningún género, se devuelve la lista vacía
                {
                    return listFiltrada;
                }
            }
            if (Nacionalidad.Trim() != "")
            {
                if (listFiltrada.Count == 0)//Si la lista filtrada está vacía se añaden los artistas que tengan la nacionalidad elegida
                {
                    foreach (Artista art in Artistas)
                    {
                        if (art.Nacionalidad.Contains(Nacionalidad, StringComparison.OrdinalIgnoreCase))
                        {
                            listFiltrada.Add(art);
                        }
                    }
                }
                else
                {
                    for (int i = listFiltrada.Count - 1; i >= 0; i--)//Si la lista no está vacía se eliminan los artistas que no tengan esa nacionalidad
                    {
                        if (!listFiltrada[i].Nacionalidad.Contains(Nacionalidad, StringComparison.OrdinalIgnoreCase))
                        {
                            listFiltrada.Remove(listFiltrada[i]);
                        }
                    }
                }
                if (listFiltrada.Count == 0) //Si la lista está vacía es porque no coincide ninguna nacionalidad, se devuelve la lista vacía
                {
                    return listFiltrada;
                }
            }
            if (Cancion.Trim() != "")
            {
                if (listFiltrada.Count == 0)//Si la lista filtrada está vacía se añaden los artistas que tengan la cancion elegida
                {
                    foreach (Artista art in Artistas)
                    {
                        if (art.CancionMasEscuchada.Contains(Cancion, StringComparison.OrdinalIgnoreCase))
                        {
                            listFiltrada.Add(art);
                        }
                    }
                }
                else
                {
                    for (int i = listFiltrada.Count - 1; i >= 0; i--)//Si la lista no está vacía se eliminan los artistas que no tengan esa canción
                    {
                        if (!listFiltrada[i].CancionMasEscuchada.Contains(Cancion, StringComparison.OrdinalIgnoreCase))
                        {
                            listFiltrada.Remove(listFiltrada[i]);
                        }
                    }
                }
                if (listFiltrada.Count == 0) //Si la lista está vacía es porque no coincide ninguna canción, se devuelve la lista vacía
                {
                    return listFiltrada;
                }
            }
            if (Puntuacion != 0.0)
            {
                if (listFiltrada.Count == 0) //Si la lista filtrada está vacía se añaden los artistas que tengan la edad elegida
                {
                    foreach (Artista art in Artistas)
                    {
                        if (art.Puntuacion == Puntuacion)
                        {
                            listFiltrada.Add(art);
                        }
                    }
                }
                else //Si la lista no está vacía se eliminan los artistas que no tengan esa edad
                {
                    for (int i = listFiltrada.Count - 1; i >= 0; i--)
                    {
                        if (listFiltrada[i].Puntuacion != Puntuacion)
                        {
                            listFiltrada.Remove(listFiltrada[i]);
                        }
                    }
                }
                if (listFiltrada.Count == 0) //Si la lista está vacía es porque no coincide ninguna puntuación, se devuelve la lista vacía
                {
                    return listFiltrada;
                }
            }
            if (Tipo != 'n')
            {
                //Si el artista es de grupo
                if (Tipo == 'g' || Tipo == 'G')
                {
                    if (listFiltrada.Count == 0)//Si la lista filtrada está vacía se añaden los artistas que sean de Grupo
                    {
                        foreach (Artista art in Artistas)
                        {
                            if (art is DeGrupo)
                            {
                                listFiltrada.Add(art);
                            }
                        }
                    }
                    else
                    {
                        for (int i = listFiltrada.Count - 1; i >= 0; i--)//Si la lista no está vacía se eliminan los artistas que no sean de Grupo
                        {
                            if (listFiltrada[i] is not DeGrupo)
                            {
                                listFiltrada.Remove(listFiltrada[i]);
                            }
                        }
                    }
                    if (NombreGrupo.Trim() != "")
                    {
                        for (int i = listFiltrada.Count - 1; i >= 0; i--)//La lista no está vacía, se eliminan los artistas que no tengan ese nombre de grupo
                        {
                            if (listFiltrada[i] is DeGrupo deGrupo && !deGrupo.NombreGrupo.Contains(NombreGrupo, StringComparison.OrdinalIgnoreCase))
                            {
                                listFiltrada.Remove(listFiltrada[i]);
                            }
                        }
                    }
                }
                //Si elige filtrar por tipo Solista
                if (Tipo == 's' || Tipo == 'S')
                {
                    if (listFiltrada.Count == 0)//Si la lista filtrada está vacía se añaden los artistas que sean Solista
                    {
                        foreach (Artista art in Artistas)
                        {
                            if (art is Solista)
                            {
                                listFiltrada.Add(art);
                            }
                        }
                    }
                    else
                    {
                        for (int i = listFiltrada.Count - 1; i >= 0; i--)//Si la lista no está vacía se eliminan los artistas que no sean Solista
                        {
                            if (listFiltrada[i] is not Solista)
                            {
                                listFiltrada.Remove(listFiltrada[i]);
                            }
                        }
                    }
                    //Si elige filtrar por nombre de pila y ese nombre no se encuentra en la lista filtrada quita ese registro
                    if (NombrePila.Trim() != "")
                    {
                        for (int i = listFiltrada.Count - 1; i >= 0; i--)//La lista no está vacía, se eliminan los artistas que no tengan ese nombre de pila
                        {
                            if (listFiltrada[i] is Solista solista && !solista.NombrePila.Contains(NombrePila, StringComparison.OrdinalIgnoreCase))
                            {
                                listFiltrada.Remove(listFiltrada[i]);
                            }
                        }
                    }
                }

            }

            Console.WriteLine("\n");

            foreach (Artista artista in listFiltrada)
            {
                Console.WriteLine(artista); //Imprime cada valor de la lista filtrada
            }

            return listFiltrada; //Devuelve la lista filtrada
        }

        //Método para modificar un artista, recibe el índice del que desea modificar y el Artista modificado
        internal void Modificar(int busqueda, Artista modificado)
        {
            
            Artistas[busqueda] = modificado;
            EscribirDatos();
        }

    }
}
