using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form2 : Form
    {
        private int number1;
        private int number2;
        private int result;

        private int inValidation;

        public Form2()
        {
            InitializeComponent();

            number1 = 0;
            number2 = 0;

            txtResult.ReadOnly = true;
        }

        private void txtNumber1_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtNumber1, "");

            int i;

            if (!int.TryParse(txtNumber1.Text, out i))
            {
                errorProvider.SetError(txtNumber1, "Please fill the required fields, only numbers are accepted here");
            }
        }

        private void txtNumber2_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(txtNumber2, "");

            int i;

            if (!int.TryParse(txtNumber2.Text, out i))
            {
                errorProvider.SetError(txtNumber2, "Please fill the required fields, only numbers are accepted here");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled)) { 
                    number1 = int.Parse(txtNumber1.Text);
                    number2 = int.Parse(txtNumber2.Text);

                    result = (number1 + number2);

                    txtResult.Text = result.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
