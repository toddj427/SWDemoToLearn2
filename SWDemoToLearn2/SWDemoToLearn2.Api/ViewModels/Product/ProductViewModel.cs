﻿/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;

namespace SWDemoToLearn2.Api.ViewModels.Product
{
    public class ProductViewModel
    {
        /// <summary>
        /// Gets or sets the product's id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the product's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product's price.
        /// </summary>
        public decimal Price { get; set; }
    }
}
