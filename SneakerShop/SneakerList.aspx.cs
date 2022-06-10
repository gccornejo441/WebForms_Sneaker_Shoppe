using SneakerShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SneakerShop
{
    public partial class SneakerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        IQueryable<Sneaker> GetSneakers([QueryString("id")] int? categoryId)
        {
            var query = Models.SneakerContext.S
        }
    }
}