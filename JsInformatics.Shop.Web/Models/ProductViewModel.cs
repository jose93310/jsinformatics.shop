
namespace JsInformatics.Shop.Web.Models
{
    using JsInformatics.Shop.Web.Data.Entities;
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set;  }
    }
}
