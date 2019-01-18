using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSwagger.Models
{
    /// <summary>
    /// 订单实体类
    /// </summary>
    public class OrderModel
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public int OrderNo { get; set; }
    }
}