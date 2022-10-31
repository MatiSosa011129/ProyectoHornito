using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Logica
{
    public class PersistenciaDatos
    {
        readonly string RutaListaClientes = @"C:\repo\BitBucket\archivos\ListaClientes.txt";
        readonly string RutaListaPedidos = @"C:\repo\BitBucket\archivos\ListaPedidos.txt";
        readonly string RutaListaEmpanadas = @"C:\repo\BitBucket\archivos\ListaEmpanadas.txt";
        readonly string RutaListaCajas = @"C:\repo\BitBucket\archivos\ListaCajas.txt";

        public void InicializarArchivos()
        {
            if (!File.Exists(RutaListaClientes))
            {
                File.Create(RutaListaClientes).Close();
            }
            if (!File.Exists(RutaListaPedidos))
            {
                File.Create(RutaListaPedidos).Close();
            }
            if (!File.Exists(RutaListaEmpanadas))
            {
                File.Create(RutaListaEmpanadas).Close();
            }
            if (!File.Exists(RutaListaCajas))
            {
                File.Create(RutaListaCajas).Close();
            }
        }

        public List<Cliente> LeerArchivoCliente()
        {
            string locationFile = RutaListaClientes;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Cliente> ListaClientes = JsonConvert.DeserializeObject<List<Cliente>>(content);
                return ListaClientes;
            }
        }

        public List<Pedido> LeerArchivoPedido()
        {
            string locationFile = RutaListaPedidos;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Pedido> ListaPedidos = JsonConvert.DeserializeObject<List<Pedido>>(content);
                return ListaPedidos;
            }
        }

        public List<Caja> LeerArchivoCaja()
        {
            string locationFile = RutaListaCajas;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Caja> ListaCajas = JsonConvert.DeserializeObject<List<Caja>>(content);
                return ListaCajas;
            }
        }

        public List<Empanada> LeerArchivoEmpanada()
        {
            string locationFile = RutaListaEmpanadas;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Empanada> ListaEmpanadas = JsonConvert.DeserializeObject<List<Empanada>>(content);
                return ListaEmpanadas;
            }
        }

        public void GuardarArchivoCliente(List<Cliente> ListaClientes)
        {
            string locationFile = RutaListaClientes;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaClientes);
                writer.WriteLine(jsonContent);
            }
        }

        public void GuardarArchivoPedido(List<Pedido> ListaPedidos)
        {
            string locationFile = RutaListaPedidos;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaPedidos);
                writer.WriteLine(jsonContent);
            }
        }

        public void GuardarArchivoCaja(List<Caja> ListaCajas)
        {
            string locationFile = RutaListaCajas;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaCajas);
                writer.WriteLine(jsonContent);
            }
        }

        public void GuardarArchivoEmpanada(List<Empanada> ListaEmpanadas)
        {
            string locationFile = RutaListaEmpanadas;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(ListaEmpanadas);
                writer.WriteLine(jsonContent);
            }
        }
    }

}

