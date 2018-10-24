﻿using Com.Moonlay.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Com.DanLiris.Service.Purchasing.Lib.Models.GarmentDeliveryOrderModel
{
    public class GarmentDeliveryOrderItem : StandardEntity<long>
    {
        public long EPOId { get; set; }
        [MaxLength(255)]
        public string EPONo { get; set; }

        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        public int PaymentDueDays { get; set; }

        [MaxLength(255)]
        public string PONo { get; set; }
        public int POId { get; set; }

        public virtual ICollection<GarmentDeliveryOrderDetail> Details { get; set; }

        public virtual long GarmentDOId { get; set; }
        [ForeignKey("GarmentDOId")]
        public virtual GarmentDeliveryOrder GarmentDeliveryOrder { get; set; }
    }
}