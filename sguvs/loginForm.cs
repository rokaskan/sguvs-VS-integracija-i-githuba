using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sguvs
{
    public partial class loginForm1 : Form
    {
        public loginForm1()
        {
            InitializeComponent();
        }

        private void prisijungtiBtn_Click(object sender, EventArgs e)
        {
            //creating instance of main form
            MainForm mainForm = new MainForm();

            // creating event handler to catch the main form closed event
            // this will fire when mainForm closed
            mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            //showing the main form
            mainForm.Show();
            //hiding the current form
            this.Hide();
        }

        //this is the method block executes when main form is closed
        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // here you can do anything

            // we will close the application
            Application.Exit();
        }

        private void loginForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
