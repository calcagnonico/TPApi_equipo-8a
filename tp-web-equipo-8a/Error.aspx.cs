using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_8a
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["error"] == null)
                {
                    Response.Redirect("IngresarVoucher.aspx", false);
                }
                else
                {
                    lblMensajeError.Text = Session["error"].ToString();
                    Session.Clear();
                }
            }
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("IngresarVoucher.aspx", false);
        }

    }
}