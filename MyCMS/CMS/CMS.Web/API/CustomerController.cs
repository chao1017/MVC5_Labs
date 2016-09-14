using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CMS.BLL;
using CMS.BLL.Services;
using CMS.Domain.ViewModels;


namespace CMS.Web.API
{
    public class CustomerController : ApiController
    {
        private CustomerService service;

        public CustomerController()
        {
            service = new CustomerService();
        }

        // GET: api/Customer
        [HttpGet]
        public HttpResponseMessage Customers()
        {
            try
            {
                // 取得客戶資料
                var data = service.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                // 發生錯誤，寫入Log，回傳失敗及錯誤訊息
                return Request.CreateResponse(HttpStatusCode.BadRequest,ex.Message.ToString());
            }
        }

        [HttpGet]
        public HttpResponseMessage Customers(int CurrPage, int PageSize)
        {
            try
            {
                // 總數量
                int TotalRow = 0;

                // 向BLL取得資料
                var data = service.Get(CurrPage, PageSize, out TotalRow);
                
                // 回傳一個JSON Object
                var Rvl = new { Total = TotalRow, Data = data };
                return Request.CreateResponse(HttpStatusCode.OK, Rvl);
            }
            catch (Exception ex)
            {
                // 發生錯誤，寫入Log，回傳失敗及錯誤訊息
                return Request.CreateResponse(HttpStatusCode.BadRequest,ex.Message.ToString());
            }
        }

        [HttpGet]
        public HttpResponseMessage Customers(int CustomerID)
        {
            try
            {
                var data = service.Get(CustomerID.ToString());
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                // 發生錯誤，寫入Log，回傳失敗及錯誤訊息
                return Request.CreateResponse(HttpStatusCode.BadRequest,ex.Message.ToString());
            }
        }
        
        // POST: api/Customer
        public HttpResponseMessage Post(CustomerViewModel models)
        {
            try
            {
                service.AddCustomer(models);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message.ToString());
            }
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
