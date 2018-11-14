using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmentThree1
{
    public partial class ShowAllForms : StudentsPreformaceForm
    {
        public ShowAllForms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close everything down.
            Application.Exit();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            new StudentsPreformaceForm().Show();
            this.Hide();
        }

       
    }
}
