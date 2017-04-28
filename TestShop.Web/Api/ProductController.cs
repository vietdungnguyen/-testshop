using AutoMapper;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using TestShop.Model.Models;
using TestShop.Service;
using TestShop.Web.Infrastructure.Core;
using TestShop.Web.Infrastructure.Extensions;
using TestShop.Web.Models;

namespace TestShop.Web.Api
{
    [RoutePrefix("api/product")]
    [Authorize]
    public class ProductController : ApiControllerBase
    {
        private IProductService _productService;

        public ProductController(IErrorService errorService, IProductService productService): base(errorService)
        {
            this._productService = productService;
        }
    // get all
    [Route("getall")]
    [HttpGet]
    public HttpResponseMessage Get(HttpRequestMessage request,string keyword,int page,int pageSize = 20)
        {
            return CreateHttpReponse(request, ()=>
            {
                int totalRow = 0;

                var listProduct = _productService.GetAll(keyword);

                totalRow = listProduct.Count();

                var query = listProduct.OrderByDescending(x => x.CreatedDate).Skip(page * pageSize).Take(pageSize);

                var listProductVm = Mapper.Map<List<ProductViewModel>>(query);

                var pagintionSet = new PaginationSet<ProductViewModel>()
                {
                    Items=listProductVm,
                    Page=page,
                    TotalCount=totalRow,
                    TotalPages=(int)Math.Ceiling((decimal)totalRow/pageSize)
                };

                HttpResponseMessage reponse = request.CreateResponse(HttpStatusCode.OK,pagintionSet);

                return reponse;
            });
        }
        [HttpGet]
        [Route("getbyid/{id:int}")]
        public HttpResponseMessage GetById(HttpRequestMessage request,int id)
        {
            return CreateHttpReponse(request, () =>
            {
                var model = _productService.GetById(id);

                var responseData = Mapper.Map<ProductViewModel>(model);

                var response = request.CreateResponse(HttpStatusCode.OK, responseData);

                return response;
            });
        }
        [Route("delete")]
        [HttpDelete]
        [AllowAnonymous]
        public HttpResponseMessage Delete(HttpRequestMessage request,int id)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage response = null;
                if(!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var model = _productService.Delete(id);
                    _productService.Save();

                    var responseData = Mapper.Map<ProductViewModel>(model);

                    response = request.CreateResponse(HttpStatusCode.OK, responseData);
                }
                return response;
            });
        }
        //delete multi
        [Route("deletemulti")]
        [HttpDelete]
        [AllowAnonymous]
        public HttpResponseMessage DeleteMulti(HttpRequestMessage request, string checkedProducts)
        {
            return CreateHttpReponse(request, () =>
             {
                 HttpResponseMessage response = null;
                 if(!ModelState.IsValid)
                 {
                     response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     var listProduct = new JavaScriptSerializer().Deserialize<List<int>>(checkedProducts);
                     foreach(var item in listProduct)
                     {
                        var model = _productService.Delete(item);
                     }

                     _productService.Save();
                     response = request.CreateResponse(HttpStatusCode.OK, listProduct.Count);
                 }
                 return response;
             });
        }
        [Route("create")]
        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage Create(HttpRequestMessage request, ProductViewModel productVm)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var newProduct = new Product();
                    newProduct.UpdateProduct(productVm);
                    newProduct.CreatedDate = DateTime.Now;
                    newProduct.CretedBy = User.Identity.Name;
                    _productService.Add(newProduct);
                    _productService.Save();

                    var reponseData = Mapper.Map<Product, ProductViewModel>(newProduct);
                    response = request.CreateResponse(HttpStatusCode.Created, reponseData);
                }

                return response;
            });
        }
        [Route("update")]
        [HttpPut]
        [AllowAnonymous]
        public HttpResponseMessage Update(HttpRequestMessage request, ProductViewModel productVm)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (!ModelState.IsValid)
                {
                    response = request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var dbProduct= _productService.GetById(productVm.ID);
                    dbProduct.UpdateProduct(productVm);
                    dbProduct.UpdatedDate = DateTime.Now;
                    dbProduct.UpdateBy = User.Identity.Name;
                    _productService.Update(dbProduct);
                    _productService.Save();

                    var reponseData = Mapper.Map<Product, ProductViewModel>(dbProduct);
                    response = request.CreateResponse(HttpStatusCode.Created, reponseData);
                }

                return response;
            });
        }
    }
}

