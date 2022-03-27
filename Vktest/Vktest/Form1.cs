using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vktest.Views;
using Vktest.Presenters;
using Npgsql;

namespace Vktest
{
    public partial class Form1 : Form, IGrid
    {
        public Form1()
        {
            InitializeComponent();
            tm = new System.Windows.Forms.Timer();
            tm.Tick += new EventHandler(draw);
            tm.Interval = 3000;
        }
        System.Windows.Forms.Timer tm = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            tm.Start();
            draw(sender, e);
   
        }
        private void  draw(object sender, EventArgs e)
        {
            GridPresenter presenter = new GridPresenter(this);
            Graphics g = this.CreateGraphics();
            presenter.Area(g);
        }
    }
}
