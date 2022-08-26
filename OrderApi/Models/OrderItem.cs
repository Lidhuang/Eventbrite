﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApi.Models
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public decimal UnitPrice { get; set; }
        public int Units { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }

        public OrderItem(int productId, string productName, decimal unitPrice, string pictureUrl, int units=1)
        {

            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            PictureUrl = pictureUrl;
            Units = units;           
        }

        public void SetPictureUri(string pictureUri)
        {
            if (!string.IsNullOrEmpty(pictureUri))
            {
                PictureUrl = pictureUri;
            }
        }

        public void AddUnits(int units)
        {
            units += units;
        }
    }
}
