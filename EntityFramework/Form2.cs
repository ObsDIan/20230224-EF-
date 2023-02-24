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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactTable data = new ContactTable()
            {
                P_Name = textBox1.Text.Trim(),
                P_ID = textBox2.Text.Trim(),
                P_Class = textBox3.Text.Trim()
            };
            try
            {
                Model1 context = new Model1();
                context.ContactTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤 {ex.ToString()}");
            }
        }
    }
}
