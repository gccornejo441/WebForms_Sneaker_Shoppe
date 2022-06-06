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
    public partial class ShirtList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Shirt> GetShirts([QueryString("id")] int? categoryId)
        {
            var _db = new SneakerShop.Models.SneakerContext();
            IQueryable<Shirt> query = _db.Shirts;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }

    }
}