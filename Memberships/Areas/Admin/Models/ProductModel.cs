using Memberships.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Memberships.Areas.Admin.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(2048)]
        public string Description { get; set; }
        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }
        public int ProductLinkTextId { get; set; }
        public int ProductTypeId { get; set; }
        [DisplayName("Product Link Text")]
        public ICollection<ProductLinkText> ProductLinkTexts { get; set; }
        [DisplayName("Product Type")]
        public ICollection<ProductType> ProductTypes { get; set; }

        public string ProductType {
            get {
                return ProductTypes == null || ProductTypes.Count.Equals(0) ?
                    String.Empty : ProductTypes.First(pt => pt.Id.Equals(ProductTypeId)).Title;
            } }

        public string ProductLinkText
        {
            get
            {
                return ProductLinkTexts == null || ProductLinkTexts.Count.Equals(0) ?
                    String.Empty : ProductLinkTexts.First(plt => plt.Id.Equals(ProductLinkTextId)).Title;
            }
        }
    }
}