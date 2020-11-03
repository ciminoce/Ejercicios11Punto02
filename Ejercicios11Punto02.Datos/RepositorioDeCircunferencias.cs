using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ejercicios11Punto02.Entidades;
using Ejercicios11Punto02.Enum;

namespace Ejercicios11Punto02.Datos
{
    public class RepositorioDeCircunferencias
    {
        private readonly string _archivo = Environment.CurrentDirectory + @"\Circunferencias.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\Circunferencias.bak";

        public List<Circunferencia> Circunferencias { get; set; }=new List<Circunferencia>();

        public RepositorioDeCircunferencias()
        {
            //Circunferencias=new List<Circunferencia>();
            LeerDesdeArchivo();
        }

        public List<Circunferencia> GetLista()
        {
            return Circunferencias;
        }
        public int GetCantidad()
        {
            return Circunferencias.Count;
        }

        private void LeerDesdeArchivo()
        {
            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Circunferencia circ = ConstruirCirc(linea);
                    Circunferencias.Add(circ);
                }
                lector.Close();

            }

        }

        private Circunferencia ConstruirCirc(string linea)
        {
            var campos = linea.Split(';');
            Circunferencia circ = new Circunferencia
            {
                Radio = int.Parse(campos[0]),
                Centro = new Punto()
                {
                    CoordenadaX = int.Parse(campos[1]),
                    CoordenadaY = int.Parse(campos[2])
                },
                Borde = (Borde) byte.Parse(campos[3]),
                Relleno = campos[4]
            };
            return circ;
        }

        public void GuardarEnArchivo(Circunferencia circunferencia)
        {
            StreamWriter escritor=new StreamWriter(_archivo,true);
            string linea = ConstruirLinea(circunferencia);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Circunferencia circunferencia)
        {
            return $"{circunferencia.Radio};{circunferencia.Centro.CoordenadaX};" +
                   $"{circunferencia.Centro.CoordenadaY};{circunferencia.Borde.GetHashCode()};" +
                   $"{circunferencia.Relleno}";
        }

        public bool Borrar(Circunferencia circunferencia)
        {
            if (BorrarDeArchivo(circunferencia))
            {
                Circunferencias.Remove(circunferencia);
                return true;
            }

            return false;
        }

        private bool BorrarDeArchivo(Circunferencia circunferencia)
        {
            var borrado = false;
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Circunferencia circEnArchivo = ConstruirCirc(linea);
                if (!circEnArchivo.Equals(circunferencia))
                {
                    escritor.WriteLine(linea);
                }
                else
                {
                    borrado = true;
                }
            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak,_archivo);
            return borrado;
        }

        public bool Editar(Circunferencia circOriginal, Circunferencia circNueva)
        {
            var editado = false;
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Circunferencia circEnArchivo = ConstruirCirc(linea);
                if (circEnArchivo.Equals(circOriginal))
                {
                    linea = ConstruirLinea(circNueva);
                    editado = true;
                }
                escritor.WriteLine(linea);
            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
            return editado;

        }
        public void Agregar(Circunferencia circunferencia)
        {
            GuardarEnArchivo(circunferencia);
            Circunferencias.Add(circunferencia);
        }

        public List<Circunferencia> OrdenarPorCoordenadaXDelCentro()
        {
            return Circunferencias.OrderBy(c => c.Centro.CoordenadaX)
                .ThenBy(c=>c.Centro.CoordenadaY)
                .ThenBy(c=>c.Radio).ToList();
        }
    }
}
