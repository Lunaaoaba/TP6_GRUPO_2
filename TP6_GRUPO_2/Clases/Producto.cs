using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_Grupo_2_V1.Clases
{
    public class Producto
    {
        private int _idProducto;
        private string _nombreProducto;
        private int _idProveedor;
        private int _idCategoria;
        private string _cantidadPorUnidad;
        private decimal _precioUnidad;
        private short _unidadesEnExistencia;
        private short _unidadesEnPedido;
        private short _nivelNuevoPedido;
        private bool _suspendido;

        public Producto()
        {

        }
        public Producto(int idProducto)
        {
            _idProducto = idProducto;
        }

        public Producto(int idproducto, string nombreproducto, string cantidadporunidad, decimal preciounidad)
        {
            _idProducto = idproducto;
            _nombreProducto = nombreproducto;
            _cantidadPorUnidad = cantidadporunidad;
            _precioUnidad = preciounidad;
        }


        public Producto(int idProducto, string nombreProducto, int idProveedor, int idCategoria,
                        string cantidadPorUnidad, decimal precioUnidad, short unidadesEnExistencia,
                        short unidadesEnPedido, short nivelNuevoPedido, bool suspendido)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _idProveedor = idProveedor;
            _idCategoria = idCategoria;
            _cantidadPorUnidad = cantidadPorUnidad;
            _precioUnidad = precioUnidad;
            _unidadesEnExistencia = unidadesEnExistencia;
            _unidadesEnPedido = unidadesEnPedido;
            _nivelNuevoPedido = nivelNuevoPedido;
            _suspendido = suspendido;
        }


        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; }
        }

        public int IdProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }

        public int IdCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        public string CantidadPorUnidad
        {
            get { return _cantidadPorUnidad; }
            set { _cantidadPorUnidad = value; }
        }

        public decimal PrecioUnidad
        {
            get { return _precioUnidad; }
            set { _precioUnidad = value; }
        }

        public short UnidadesEnExistencia
        {
            get { return _unidadesEnExistencia; }
            set { _unidadesEnExistencia = value; }
        }

        public short UnidadesEnPedido
        {
            get { return _unidadesEnPedido; }
            set { _unidadesEnPedido = value; }
        }

        public short NivelNuevoPedido
        {
            get { return _nivelNuevoPedido; }
            set { _nivelNuevoPedido = value; }
        }

        public bool Suspendido
        {
            get { return _suspendido; }
            set { _suspendido = value; }
        }
    }
}
