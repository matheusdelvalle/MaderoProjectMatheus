
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMatheus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //QUESTION 1
        private void button1_Click(object sender, EventArgs e)
        {
            int[] arrayTeste = new int[10];
            arrayTeste[0] = 0;
            arrayTeste[1] = 1;
            arrayTeste[2] = 2;
            arrayTeste[3] = 3;

            int result = calculateArray(arrayTeste);
            MessageBox.Show("resultado: " + result);       
        }

        private int calculateArray(int[] array) {
        
            int result = 0;
            for (int i = 0; i < array.Length; i++) {
                result += array[i];
            }
            return result;
        }
       





        //QUESTION 4
        private void button2_Click(object sender, EventArgs e)
        {
            Circle cir = new Circle();

            //i did it because i couldn't change de class circle and i neeeded to change de value of the radius;
            //if you do not use this code, the result will be always 0
            var field = cir.GetType().GetField("radius", BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(cir, 5);


            double circ = cir.Calculate((radius) => 2 * Math.PI * radius);

            MessageBox.Show("" + circ);

        }
    }
}


public sealed class Circle {
    private double radius;

    public double Calculate(Func<double, double> op) {
        return op(radius);
    }

}
