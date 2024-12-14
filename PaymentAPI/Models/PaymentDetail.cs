﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string CardOwner { get; set; } = "";
        [Column(TypeName = "nvarchar(16)")]
        //mm/yy
        public string CardNumber { get; set; } = "";
        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; } = "";
        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; } = "";

    }
}
