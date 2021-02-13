using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //ATTRIBUTE 
    public class ProductsController : ControllerBase
    {
        //Looseyl coupled
        //naming convention
        //IoC Container -- Inversion of Control
        IProductService _productService; //field
        
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           // IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result); //200k
            }


            return BadRequest(result); //400k


            //return new List<Product>
            //{
            //    new Product{ProductId = 1, ProductName = "Elma"},
            //    new Product{ProductId = 2, ProductName = "Armut"},
            //};

            //Break point : sayının başına tıklamak
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")] //request 
        //Güncelleme ve silme içinde post kullanılabilir
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
