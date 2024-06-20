﻿namespace Capa.Datos.Entidades
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public Guid ProductId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public Guid CartId { get; set; }
        public Cart Cart { get; set; }

    }
}
