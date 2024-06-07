﻿using AutoMapper;
using Capa.Aplicacion.DTO;
using Capa.Aplicacion.Servicios.Interfaces;
using Capa.Datos.Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarritoDeCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductoController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductoDTO>> Get()
        {
            var products = await _productService.Get(null, p => p.Categoria, true);

            var productosDto = _mapper.Map<IEnumerable<ProductoDTO>>(products);

            return productosDto;
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
