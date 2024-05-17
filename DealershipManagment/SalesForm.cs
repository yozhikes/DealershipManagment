using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealershipManagment
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            salesDgv.DefaultCellStyle.Font = new Font("Times New Roman", 14);
            salesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
