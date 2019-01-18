using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestSwagger.Models;

namespace TestSwagger.Controllers
{
    /// <summary>
    /// 订单
    /// </summary>
    public class OrderController : ApiController
    {
        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="id">订单Id</param>
        /// <returns></returns>
        public OrderModel Get(int id)
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
