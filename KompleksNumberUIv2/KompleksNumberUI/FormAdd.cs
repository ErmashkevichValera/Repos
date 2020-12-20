using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComplexNumbers;
using Exceptions;
using ComplexNumberCheck;

namespace CompleksNumberUI
{   /// <summary>
    /// Class form add complex number
    /// </summary>
    public partial class FormAdd : Form
    {
        /// <summary>
        /// Constructor with params
        /// </summary>
        public FormAdd(List<ComplexNumber> numbers)
        {
            InitializeComponent();
            this.Numbers = numbers;
        }
        /// <summary>
        /// Collections complex numbers
        /// </summary>
        private List<ComplexNumber> Numbers { get; set; }
        /// <summary>
        /// Flag to check input
        /// </summary>
        private static bool flag;
        /// <summary>
        /// Checking input char
        /// </summary>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 45 && number != 46)
                e.Handled = true;
        }
        /// <summary>
        /// Checking input char
        /// </summary>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 45 && number != 46)
                e.Handled = true;
        }
        /// <summary>
        /// Button for add complex number
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                int real;
                CheckException.CheckInput(input, out real);
                int imaginary;
                input = textBox2.Text;
                CheckException.CheckInput(input, out imaginary);
                ComplexNumber number = new ComplexNumber(real, imaginary);
                Numbers.Add(number);
                ShowGoodMessage();
            }
            catch(IncorrectValueException exception)
            {
                ShowErrorMessage(exception.Message);
            }
            this.Close();
        }
        /// <summary>
        /// Shows a good message
        /// </summary>
        private void ShowGoodMessage()
        {
            MessageBox.Show("The complex number has been added.", "Addition result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows a error message
        /// </summary>
        private static void ShowErrorMessage(string message)
        {
            MessageBox.Show("The complex number hasn't been added. " + message, "Addition result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
