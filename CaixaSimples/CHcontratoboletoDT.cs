using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaSimples
{
    public partial class CHcontratoboletoDT : frmFormulario
    {
        public CHcontratoboletoDT(DSBoletos ds)
        {

            InitializeComponent();
            dt.DataSource = ds.tbl_Mes;
        }

        private void CHcontratoboletoDT_Load(object sender, EventArgs e)
        {

        }
    }
}
