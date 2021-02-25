using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Liste_et_Tableaux
{
    public partial class Form1 : Form
    {
        double[,] prix = new double[,]{
            { 350.25, 0, 0, 0, 0 },
            { 750.5, 0, 0, 0, 0 },
            { 49.5,49.5,55.5,55.5,55.5},
            { 0, 0, 49, 52, 0 },
            {800,0,355,700,0},
            {1200,1200,1100,0,0},
            {0,0,0,0,50 },
            {350,0,0,0,0}
        };
        string[] colors = new string[] { "Red", "green", "white", "black", "Gris" };
        string[] Articls = new string[] { "Chaise en teck", "Table en teck", "Chaise en Pvc","Table en Pvc", "Chaise du bereau prestige", "Table du bereau prestige","Tapis de souris","Visual basic facile" };

        


        public Form1()
        {

            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Articls);
            comboBox2.Items.AddRange(colors);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                textBox1.Text = Articls[comboBox1.SelectedIndex] + " " + colors[comboBox2.SelectedIndex];
                if(prix[comboBox1.SelectedIndex, comboBox2.SelectedIndex]!=0){
                    textBox2.Text = "This  Articl costs " + Convert.ToString(prix[comboBox1.SelectedIndex, comboBox2.SelectedIndex])+" $";
                }
                else
                {
                    textBox2.Text = "this Article doesn't exist with that color ";
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                textBox1.Text = Articls[comboBox1.SelectedIndex] + " " + colors[comboBox2.SelectedIndex];
                if (prix[comboBox1.SelectedIndex, comboBox2.SelectedIndex] != 0)
                {
                    textBox2.Text = "This  Articl costs " + Convert.ToString(prix[comboBox1.SelectedIndex, comboBox2.SelectedIndex]) + " $";
                }
                else
                {
                    textBox2.Text = "this Article doesn't exist with that color";
                }
            }
        }
    }
}
