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
            var _db = new SneakerShop.Models.SneakerContext();
            IQueryable<Sneaker> query = _db.Sneakers;
                if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(q => q.CategoryID == categoryId);
            }
            return query;
        }
    }
}