using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindData();
            
        }

        private void BindData()
        {
            var context = new Model1();

            var list = context.ContactTable.ToList();
            dataGridView1.DataSource = list;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewFrom viewFrom = new ViewFrom();
            viewFrom.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }

    
}
