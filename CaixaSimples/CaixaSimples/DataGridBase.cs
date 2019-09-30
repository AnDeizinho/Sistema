using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaSimples
{
    class DataGridBase : DataGridView
    {
        public DataGridBase()
        {
            this.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "gridBase";
            this.Size = new System.Drawing.Size(670, 498);
            this.TabIndex = 0;
            this.RowHeadersVisible = false;
            this.ReadOnly = true;
        }
    }
}
