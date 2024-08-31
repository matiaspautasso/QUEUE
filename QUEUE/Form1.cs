using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUEUE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsQueue peopleRow = new ClsQueue();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ClsNode OBJ = new ClsNode();
            OBJ.Code = int.Parse(txtCode.Text);
            OBJ.Name = txtName.Text;
            OBJ.Proccess = txtProcess.Text;

            peopleRow.iNSERT(OBJ);
            peopleRow.Navigate(DgvCola);
            peopleRow.Navigate(lstQueue);
            peopleRow.Navigate();
            txtCode.Text = "";
            txtName.Text = "";
            txtProcess.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (peopleRow.First != null)
            {
                lblCode.Text = peopleRow.First.Code.ToString();
               
                lblName.Text = peopleRow.First.Name.ToString();
                lblProcess.Text = peopleRow.First.Proccess.ToString();
                peopleRow.Delete();
                peopleRow.Navigate(DgvCola);
                peopleRow.Navigate(lstQueue);
                peopleRow.Navigate();


            }
            else
            {
                lblCode.Text = "";
                lblName.Text = "";
                lblProcess.Text = "";

            }

        }
    }
}
