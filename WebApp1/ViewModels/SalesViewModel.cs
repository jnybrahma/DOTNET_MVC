﻿using System.ComponentModel.DataAnnotations;
using CoreBusiness;
using WebApp1.ViewModels.Validations;

namespace WebApp1.ViewModels
{
    public class SalesViewModel
    {
        public int SelectedCategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();

        public int SelectedProductId {  get; set; }

        [Display(Name =" Quantity")]
        [Range(1,int.MaxValue)]
        [SalesViewModel_EnsureProperQuantity]
        public int QuantityToSell { get; set; } 

    }
}
