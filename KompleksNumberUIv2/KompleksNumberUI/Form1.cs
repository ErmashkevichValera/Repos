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
{
    /// <summary>
    /// Class main form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Collections complex number
        /// </summary>
        public List<ComplexNumber> Numbers { get; set; }
        /// <summary>
        /// Collections for output complex number
        /// </summary>
        public List<string> OutputNumbers { get; set; }
        /// <summary>
        /// Construcnot without params
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Numbers = new List<ComplexNumber>();
            OutputNumbers = new List<string>();
        }
        /// <summary>
        /// Selected items 
        /// </summary>
        const int checkedItemsLimit = 2;
        /// <summary>
        /// Method for output complex number 
        /// </summary>
        public void Output()
        {
            NumberOutput(Numbers);
            checkedListBox1.Items.Clear();
            foreach(string outputNumber in OutputNumbers)
            {
                checkedListBox1.Items.Add(outputNumber);
            }
        }/// <summary>
        /// Method for create collections output complex numbers
        /// </summary>
        public void NumberOutput(List<ComplexNumber> numbers)
        {
            OutputNumbers.Clear();
            foreach(ComplexNumber number in numbers)
                OutputNumbers.Add(NumberOutputString(number));
        }
        /// <summary>
        /// Method for create string output complex number
        /// </summary>
        /// <returns>string output complex number</returns>
        private string NumberOutputString(ComplexNumber number)
        {
            string str = "";
            if (number.imaginaryPart < 0)
            {
                if (number.validPart != 0)
                    str = number.validPart.ToString();
                if (number.imaginaryPart != 0)
                    str = str + number.imaginaryPart.ToString() + "i";
            }
            else
            {
                if (number.validPart != 0 && number.imaginaryPart != 0)
                    str = number.validPart.ToString() + "+" + number.imaginaryPart.ToString() + "i";
                else if (number.validPart == 0)
                    str = number.imaginaryPart.ToString() + "i";
                else if (number.imaginaryPart == 0)
                    str = number.validPart.ToString();
            }
            return str;
        }
        /// <summary>
        /// Event add complex number
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            var formAdd = new FormAdd(Numbers);
            formAdd.ShowDialog();
            Output();
        }
        /// <summary>
        /// Method for check count selected items
        /// </summary>
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (checkedListBox1.CheckedItems.Count == checkedItemsLimit)
                {
                    e.NewValue = CheckState.Unchecked;
                }
            }
        }
        /// <summary>
        /// Method for calculation
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            string strSum = null;
            string strPro = null;
            try
            {
                CheckException.CheckSelectedItemsCount(checkedListBox1.CheckedItems.Count, checkedItemsLimit);
                ComplexNumber numberSum = Numbers[checkedListBox1.CheckedIndices[0]] + Numbers[checkedListBox1.CheckedIndices[1]];
                strSum = NumberOutputString(numberSum);
                ComplexNumber numberPro = Numbers[checkedListBox1.CheckedIndices[0]] * Numbers[checkedListBox1.CheckedIndices[1]];
                strPro = NumberOutputString(numberPro);
                label3.Text = "Sum: " + strSum;
                label4.Text = "Composition: " + strPro;
            }
            catch(IncorrectSelectedException exception)
            {
                ShowErrorMessage(exception.Message);
                label3.Text = "";
                label4.Text = "";
            }
        }

        /// <summary>
        /// Shows a error message
        /// </summary>
        private static void ShowErrorMessage(string message)
        {
            MessageBox.Show("Incorrect selected. " + message, "Addition result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
