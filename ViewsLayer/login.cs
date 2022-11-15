using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSeriesPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtHost.Text = "localhost";
            txtDataBase.Text = "adminseriesdb";
            txtPass.Text = "";
            txtPort.Text = "3306";
            txtUser.Text = "root";



        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //string host = txtHost.Text;
            //string port = txtPort.Text;
            //string db = txtDataBase.Text;
            //string user = txtUser.Text;
            //string pass = txtPass.Text;
            string host = txtHost.Text;
            string port = txtPort.Text;
            string db = txtDataBase.Text;
            string user = txtUser.Text;
            string pass = txtPass.Text;
            bool connectOk = false;
            BusinessLayer.BLDataBase connection = new BusinessLayer.BLDataBase();
            connectOk = connection.connect(host,port,db,user,pass);

            if (connectOk == true) {
                ViewsLayer.ABML abml = new ViewsLayer.ABML();
                abml.Show();
            this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            BusinessLayer.BLDataBase connection = new BusinessLayer.BLDataBase();
            connection.close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
