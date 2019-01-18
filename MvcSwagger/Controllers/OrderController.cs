using MvcSwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcSwagger.Controllers
{
    /// <summary>
    /// 订单
    /// </summary>
    public class OrderController : ApiController
    {
        // GET: Order
        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="id">订单Id</param>
        /// <returns></returns>
        public OrderModel Detail(int id)
        {
            OrderModel result = new OrderModel
            {
                Id = 1,
                OrderNo = 123456789
            };
            return result;
        }
    }
}