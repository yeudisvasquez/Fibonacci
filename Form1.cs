using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtvalor1.Text, out int start) && int.TryParse(txtvalor2.Text, out int end))
            {
                // Validate start and end values
                if (start <= 0 || end <= 0 || end < start)
                {
                    MessageBox.Show("Por favor introduzca un valor en el segundo text que sea mayor al valor que el del primer text.");
                    txtvalor1.Clear();
                    txtvalor2.Clear();
                    return;
                }

                // Calculate Fibonacci sequence
                int a = start, b = start, c;

                listBox1.Items.Add(a); // Start the sequence with 0

                while (b <= end)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    listBox1.Items.Add(a);
                    /*
                    if (a >= start && a <= end)
                    {
                        listBox1.Items.Add(a);
                    }*/
                }
            }
            else
            {
                MessageBox.Show("Por favor introduzca valores enteros.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtvalor1.Clear();
            txtvalor2.Clear();
            listBox1.Items.Clear();
        }
    }
}

/*
 * Explanation 
-The btnGenerate_Click method retrieves the start and end values from txtStart and txtEnd textboxes.
-It validates the input values to ensure they are valid integers and the end value is greater than or equal to the start value.
-It then calculates Fibonacci numbers starting from 0 until the Fibonacci number is greater than the end value or less than the start value.
-Valid Fibonacci numbers within the specified range are added to the fibonacciSequence list.
-Finally, it binds this list to a ListBox (assuming you have a ListBox named listBoxSequence) to display the Fibonacci sequence.
*/