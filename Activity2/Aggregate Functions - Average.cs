using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Aggregate_Functions_Average : Form
    {
        private int subject1;
        private int subject2;
        private int result;

        private bool bSubjec1 = false;
        private bool bSubjec2 = false;
        private bool bResult = false;

        private int average;

        private int intValidation;
        private ErrorProvider errorProvider = new ErrorProvider();

        public Aggregate_Functions_Average()
        {
            InitializeComponent();

            subject1 = 0;
            subject2 = 0;

            txtAverage.ReadOnly = true;


        }

        private void txtSubject1_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtSubject1, "");

            if (!int.TryParse(txtSubject1.Text, out intValidation))
            {
                bSubjec1 = true;
                errorProvider.SetError(txtSubject1, "Please fill the required fields, only numbers accepted here");
            }

        }

        private void txtSubject2_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(txtSubject2, "");

            if (!int.TryParse(txtSubject2.Text, out intValidation))
            {
                bSubjec2 = true;
                errorProvider.SetError(txtSubject2, "Please fill the required fields, only numbers accepted here");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bSubjec2 == false && bSubjec2 == false)
                {
                    subject1 = int.Parse(txtSubject1.Text);
                    subject2 = int.Parse(txtSubject2.Text);

                    result = ((subject1 + subject2) / 2);

                    txtAverage.Text = result.ToString();

                    if (result >= 0 && result <= 40)
                    {
                        lblMark.Text = "Grade F";
                    }
                    else if (result >= 40 && result <= 65)
                    {
                        lblMark.Text = "Grade C";
                    }
                    else if (result >= 65 && result <= 75)
                    {
                        lblMark.Text = "Grade B";
                    }
                    else if (result >= 75 && result <= 100)
                    {
                        lblMark.Text = "Grade A";
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
