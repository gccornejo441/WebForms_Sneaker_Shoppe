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
    public partial class SneakerDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Sneaker> GetSneaker([QueryString("sneakerID")] int? sneakerId)
        {
            var _db = new SneakerShop.Models.SneakerContext();
            IQueryable<Sneaker> query = _db.Sneakers;
            if (sneakerId.HasValue && sneakerId > 0)
            {
                query = query.Where(p => p.SneakerID == sneakerId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}