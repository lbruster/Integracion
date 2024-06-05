using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Entidades;

namespace Data
{
    public static class ProductoData
    {
        public static List<Producto> listaProducto = new List<Producto>
        {
            new Producto { Id=1, NombreProducto="Producto 1",Categoria="Computadoras", Marca="HP", Precio=2000},
            new Producto { Id=2, NombreProducto="Producto 2",Categoria="Computadoras", Marca="Asus", Precio=2500},
            new Producto { Id=3, NombreProducto="Producto 3",Categoria="Computadoras", Marca="Dell", Precio=1500},
            new Producto { Id=4, NombreProducto="Producto 4",Categoria="Computadoras", Marca="Apple", Precio=4500},
        };
    }
}