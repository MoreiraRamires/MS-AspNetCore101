// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ContosoCrafts.WebSite.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\courses\Microsoft\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\courses\Microsoft\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\courses\Microsoft\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
using ContosoCrafts.WebSite.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Projects\courses\Microsoft\ContosoCrafts\ContosoCrafts.WebSite\Components\ProductList.razor"
 
    Product selectedProduct;
    string selectedProductId;

    void SelectProduct(string productId)
    {
      selectedProductId = productId;
      selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
