using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            StudentInfoClass.LastName = tbLastName.Text.ToString();
            StudentInfoClass.FirstName = tbFirstName.Text.ToString();
            StudentInfoClass.MiddleName = tbMiddleName.Text.ToString();
            StudentInfoClass.Address = tbAddress.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(tbAge.Text.ToString());
            StudentInfoClass.ContactNo = Convert.ToInt64(tbContactNo.Text.ToString());
            StudentInfoClass.StudentNo = Convert.ToInt64(tbStudentNo.Text.ToString());

            FrmConfirm frmConfirm = new FrmConfirm();
            DialogResult result = frmConfirm.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbLastName.Text = "";
                tbFirstName.Text = "";
                tbMiddleName.Text = "";
                tbAddress.Text = "";
                cbProgram.SelectedIndex = -1;
                tbAge.Text = "";
                tbContactNo.Text = "";
                tbStudentNo.Text = "";
            }
            else
            {
                MessageBox.Show("Registration was not confirmed. Try again.");
            }
        }
    }
}
