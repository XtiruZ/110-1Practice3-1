using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice3_1
{
    public partial class Recu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int total;
            int z = 4;
            if (z % 2 != 0)
            {
                total = Add(z);
                Response.Write(total);
            }
            else
            {
                total = Even(z);
                Response.Write(total);
            }
        }

        int Add(int x)
        {
            if (x == 1)
                return 11;
            else if (x == 2)
                return 11 + 4;
            else
                return Add(x - 2) + Add(x - 1);
        }
        int Even(int y)
        {
            if (y == 1)
                return 11;
            else if (y == 2)
                return 18;
            else
                return Even(y - 2) + Even(y - 1);

        }
    }
}