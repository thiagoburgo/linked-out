using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Qualiti.LinkedOut.WebSite {
    //Ciclo de vida da pagina: http://msdn.microsoft.com/en-us/library/ms178472%28VS.100%29.aspx
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Render(object sender, EventArgs e)
        {
            //Button novoBotao = new Button();
            
            //novoBotao.Text = "Adicionado Dinamicamente";
            //novoBotao.ForeColor = Color.Red;
            //this.Panel1.Controls.Add(novoBotao);
            this.Response.Write("HUHU");
        }

        protected void Page_Load(object sender, EventArgs e) {
          
        }
    }
}
