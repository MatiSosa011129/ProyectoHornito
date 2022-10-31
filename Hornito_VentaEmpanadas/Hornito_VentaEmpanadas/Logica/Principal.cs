using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        List<Cliente> ListaClientes = new List<Cliente>();
        List<Pedido> ListaPedidos = new List<Pedido>();
        List<Empanada> ListaEmpanadas = new List<Empanada>();
        List<Caja> ListaCajas = new List<Caja>();
        public void AltaCliente(Cliente clienteNuevo)
        {
            Cliente nuevoCliente = new Cliente();
            ListaClientes = ValidarCliente();
            if (ListaClientes.Count == 0)
            {
                int idcliente = ListaClientes.Count;
                idcliente = idcliente + 1;
                nuevoCliente.idCliente = idcliente;
            }
            else
            {
                int idcliente = ListaClientes.Count;
                idcliente = idcliente + 1;
                nuevoCliente.idCliente = idcliente;
            }
            
            nuevoCliente.dni = clienteNuevo.dni;
            nuevoCliente.telefono = clienteNuevo.telefono;
            nuevoCliente.apellido = clienteNuevo.apellido;
            nuevoCliente.fechaNacimiento = clienteNuevo.fechaNacimiento;
            nuevoCliente.nombre = clienteNuevo.nombre;
            
            ListaClientes.Add(nuevoCliente);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaClientes);

        }
        public void AltaPedidos(Pedido pedidoNuevo)
        {
            Pedido nuevoPedido = new Pedido();
            ListaPedidos = ValidarPedido();
            if (ListaPedidos.Count == 0)
            {
                int idpedido = ListaPedidos.Count;
                idpedido = idpedido + 1;
                nuevoPedido.idPedido = idpedido;
            }
            else
            {
                int idpedido = ListaPedidos.Count;
                idpedido = idpedido + 1;
                nuevoPedido.idPedido = idpedido;
            }
            nuevoPedido.estado = pedidoNuevo.estado;
            nuevoPedido.cantEmpanada = pedidoNuevo.cantEmpanada;
            nuevoPedido.formaPago = pedidoNuevo.formaPago; 
            nuevoPedido.demora = pedidoNuevo.demora;
            nuevoPedido.precioTotal = pedidoNuevo.precioTotal;
            nuevoPedido.nomCliente = pedidoNuevo.nomCliente;
            ListaPedidos.Add(nuevoPedido);
            InstanciaPersistenciaDatos.GuardarArchivoPedido(ListaPedidos);

        }
        public void AltaEmpanadas(Empanada empanadaNueva)
        {
            Empanada nuevaEmpanada = new Empanada();
            ListaEmpanadas = ValidarEmpanada();
            if (ListaEmpanadas.Count == 0)
            {
                int idempanada = ListaEmpanadas.Count;
                idempanada = idempanada + 1;
                nuevaEmpanada.idEmpanada = idempanada;
            }
            else
            {
                int idempanada = ListaEmpanadas.Count;
                idempanada = idempanada + 1;
                nuevaEmpanada.idEmpanada = idempanada;
            }
            nuevaEmpanada.gustoEmpanada = empanadaNueva.gustoEmpanada;
            nuevaEmpanada.precioEmpanada = empanadaNueva.precioEmpanada;
            ListaEmpanadas.Add(nuevaEmpanada);
            InstanciaPersistenciaDatos.GuardarArchivoEmpanada(ListaEmpanadas);
        }
        public void AltaCajas(Caja cajaNueva, int idcaja)
        {
            Caja nuevaCaja = new Caja();
            nuevaCaja.capacidadCaja = cajaNueva.capacidadCaja;
            nuevaCaja.idCaja = idcaja;
            ListaCajas.Add(nuevaCaja);
            InstanciaPersistenciaDatos.GuardarArchivoCaja(ListaCajas);
        }
        public void BajaClientes(int idcliente)
        {
            ListaClientes = ValidarCliente();
            var clienteEliminado = ListaClientes.Find(x => idcliente == x.idCliente);
            ListaClientes.Remove(clienteEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaClientes);
        }
        public void BajaPedidos(int idpedido)
        {
            ListaPedidos = ValidarPedido();
            var pedidoEliminado = ListaPedidos.Find(x => idpedido == x.idPedido);
            ListaPedidos.Remove(pedidoEliminado);
            InstanciaPersistenciaDatos.GuardarArchivoPedido(ListaPedidos);
        }
        public void BajaEmpanadas(int idempanada)
        {
            ListaEmpanadas = ValidarEmpanada();
            var empanadaEliminada = ListaEmpanadas.Find(x => idempanada == x.idEmpanada);
            ListaEmpanadas.Remove(empanadaEliminada);
            InstanciaPersistenciaDatos.GuardarArchivoEmpanada(ListaEmpanadas);
        }
        public void BajaCajas(int idcaja)
        {
            var cajaEliminada = ListaCajas.Find(x => idcaja == x.idCaja);
            ListaCajas.Remove(cajaEliminada);
            InstanciaPersistenciaDatos.GuardarArchivoCaja(ListaCajas);
        }
        public void ModificarCliente(Cliente clienteNuevo, int idCliente)
        {
            var clienteModificado = ListaClientes.Find(x => idCliente == x.idCliente);
            clienteModificado.idCliente = idCliente;
            clienteModificado.telefono = clienteNuevo.telefono;
            clienteModificado.apellido = clienteNuevo.apellido;
            clienteModificado.dni = clienteNuevo.dni;
            clienteModificado.fechaNacimiento = clienteNuevo.fechaNacimiento;
            clienteModificado.nombre = clienteNuevo.nombre;
            var clienteEliminado = ListaClientes.Find(x => idCliente == x.idCliente);
            ListaClientes.Remove(clienteEliminado);
            ListaClientes.Add(clienteModificado);
            InstanciaPersistenciaDatos.GuardarArchivoCliente(ListaClientes);
        }
        public void ModificarPedido(Pedido pedidoNuevo, int idPedido)
        {
            var pedidoModificado = ListaPedidos.Find(x => idPedido == x.idPedido);
            pedidoModificado.idPedido = idPedido;
            pedidoModificado.formaPago = pedidoNuevo.formaPago;
            pedidoModificado.cantEmpanada = pedidoNuevo.cantEmpanada;
            pedidoModificado.demora = pedidoNuevo.demora;
            pedidoModificado.estado = pedidoNuevo.estado;
            pedidoModificado.precioTotal = pedidoNuevo.precioTotal;
            pedidoModificado.nomCliente = pedidoNuevo.nomCliente;
            var pedidoEliminado = ListaPedidos.Find(x => idPedido == x.idPedido);
            ListaPedidos.Remove(pedidoEliminado);
            ListaPedidos.Add(pedidoModificado);
            InstanciaPersistenciaDatos.GuardarArchivoPedido(ListaPedidos);
        }
        public void ModificarEmpanada(Empanada empanadaNueva, int idEmpanada)
        {
            var empanadaModificada = ListaEmpanadas.Find(x => idEmpanada == x.idEmpanada);
            empanadaModificada.idEmpanada = idEmpanada;
            empanadaModificada.gustoEmpanada = empanadaNueva.gustoEmpanada;
            empanadaModificada.precioEmpanada = empanadaNueva.precioEmpanada;
            var empanadaEliminada = ListaEmpanadas.Find(x => idEmpanada == x.idEmpanada);
            ListaEmpanadas.Remove(empanadaEliminada);
            ListaEmpanadas.Add(empanadaModificada);
            InstanciaPersistenciaDatos.GuardarArchivoEmpanada(ListaEmpanadas);
        }
        public void ModificarCaja(Caja cajaNueva, int idCaja)
        {
            var cajaModificada = ListaCajas.Find(x => idCaja == x.idCaja);
            cajaModificada.idCaja = idCaja;
            cajaModificada.capacidadCaja = cajaNueva.capacidadCaja;
            var cajaEliminada = ListaCajas.Find(x => idCaja == x.idCaja);
            ListaCajas.Remove(cajaEliminada);
            ListaCajas.Add(cajaModificada);
            InstanciaPersistenciaDatos.GuardarArchivoCaja(ListaCajas);
        }

        PersistenciaDatos InstanciaPersistenciaDatos = new PersistenciaDatos();
        //Relleno de listas
        public void RellenarListas()
        {
            ListaClientes = InstanciaPersistenciaDatos.LeerArchivoCliente();
            ListaPedidos = InstanciaPersistenciaDatos.LeerArchivoPedido();
            ListaCajas = InstanciaPersistenciaDatos.LeerArchivoCaja();
            ListaEmpanadas = InstanciaPersistenciaDatos.LeerArchivoEmpanada();
        }

        public List<Cliente> ValidarCliente()
        {
            ListaClientes = InstanciaPersistenciaDatos.LeerArchivoCliente();
            if (ListaClientes == null)
            {
                ListaClientes = new List<Cliente>();
            }

                return ListaClientes;

        }
        public List<Cliente> BuscarClientePorId(int idcliente)
        {
            List<Cliente> NuevaListaCliente = new List<Cliente>();
            if (ListaClientes == null)
            {
               return NuevaListaCliente;
            }
            else
            {
                var clienteObtenido = ListaClientes.Find(x => idcliente == x.idCliente);
                NuevaListaCliente.Add(clienteObtenido);
                return NuevaListaCliente;
            }
        }
        public List<Empanada> BuscarEmpanadaPorId(int idempanada)
        {
            List<Empanada> NuevaListaEmpanada = new List<Empanada>();
            if (ListaEmpanadas == null)
            {
                return NuevaListaEmpanada;
            }
            else
            {
                var empanadaObtenido = ListaEmpanadas.Find(x => idempanada == x.idEmpanada);
                NuevaListaEmpanada.Add(empanadaObtenido);
                return NuevaListaEmpanada;
            }
        }
        public List<Pedido> BuscarPedidoPorId(int idpedido)
        {
            List<Pedido> NuevaListaPedido = new List<Pedido>();
            if (ListaPedidos == null)
            {
                return NuevaListaPedido;
            }
            else
            {
                var pedidoObtenido = ListaPedidos.Find(x => idpedido == x.idPedido);
                NuevaListaPedido.Add(pedidoObtenido);
                return NuevaListaPedido;
            }
        }
        public List<Pedido> ValidarPedido()
        {
            ListaPedidos = InstanciaPersistenciaDatos.LeerArchivoPedido();
            if (ListaPedidos == null)
            {
                List<Pedido> NuevaListaPedido = new List<Pedido>();
                return NuevaListaPedido;
            }
            else
            {
                return ListaPedidos;
            }
        }
        public List<Empanada> ValidarEmpanada()
        {
            ListaEmpanadas = InstanciaPersistenciaDatos.LeerArchivoEmpanada();
            if (ListaEmpanadas == null)
            {
                List<Empanada> NuevaListaEmpanada = new List<Empanada>();
                return NuevaListaEmpanada;
            }
            else
            {
                return ListaEmpanadas;
            }
        }
        public List<Caja> ValidarCaja()
        {
            ListaCajas = InstanciaPersistenciaDatos.LeerArchivoCaja();
            if (ListaCajas == null)
            {
                List<Caja> NuevaListaCaja = new List<Caja>();
                return NuevaListaCaja;
            }
            else
            {
                return ListaCajas;
            }
        }

        public List<Cliente> BuscarClientePorNombre(string Nombre)
        {
            ListaClientes = ValidarCliente();
            List<Cliente> ListaFiltrada = new List<Cliente>();
            foreach (var cliente in ListaClientes)
            {
                if (cliente.nombre.ToString().Contains(Nombre))
                {
                    ListaFiltrada.Add(cliente);
                }
            }
            return ListaFiltrada;
        }

    }
}
