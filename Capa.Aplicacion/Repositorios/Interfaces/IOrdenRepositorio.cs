﻿using Capa.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Aplicacion.Repositorios.Interfaces
{
    public interface IOrdenRepositorio
    {
        Task<IEnumerable<Orden>> GetAllById(string userId);
        Task<Orden> Get(int ordenId);
        Task<Orden> Create(Orden orden);
        Task SaveChangesAsync();
    }
}
