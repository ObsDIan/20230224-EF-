using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class ViewFrom : Form
    {
        public ViewFrom()
        {
            InitializeComponent();
            BindData();
        }

        public void BindData()
        {
            var context = new Model1();

            var list = context.ContactTable.ToList();
            dataGridView1.DataSource = list;
        }
    }

}
