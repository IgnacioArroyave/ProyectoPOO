using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022POOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            numericUpDown1.Visible = true;
            button3.Visible = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            button4.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
            gasesToolStripMenuItem.Visible = true;
            toolStripMenuItem1.Visible = true;
            button3.Visible = false;
            //comboBox1.DataSource = GunList.Fabricantes.ToString();
           
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("porfavor ingrese valores");
                button3.Visible = true;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox3.Visible = true;
                button1.Visible = true;

                switch (numericUpDown1.Value)
                {
                    case 1:
                        comboBox6.Visible = true;
                        comboBox1.Visible = true;
                        listBox1.Visible = true;
                        listBox10.Visible = true;

                        break;
                    case 2:
                        comboBox7.Visible = true;
                        comboBox6.Visible = true;
                        comboBox1.Visible = true;
                        comboBox2.Visible = true;
                        listBox1.Visible = true;
                        listBox10.Visible = true;
                        listBox2.Visible = true;
                        listBox9.Visible = true;


                        break;
                    case 3:
                        comboBox8.Visible = true;
                        comboBox7.Visible = true;
                        comboBox6.Visible = true;
                        comboBox1.Visible = true;
                        comboBox2.Visible = true;
                        comboBox3.Visible = true;
                        listBox1.Visible = true;
                        listBox10.Visible = true;
                        listBox2.Visible = true;
                        listBox9.Visible = true;
                        listBox3.Visible = true;
                        listBox8.Visible = true;
                        break;
                    case 4:
                        comboBox9.Visible = true;
                        comboBox8.Visible = true;
                        comboBox7.Visible = true;
                        comboBox6.Visible = true;
                        comboBox1.Visible = true;
                        comboBox2.Visible = true;
                        comboBox3.Visible = true;
                        comboBox4.Visible = true;
                        listBox1.Visible = true;
                        listBox10.Visible = true;
                        listBox2.Visible = true;
                        listBox9.Visible = true;
                        listBox8.Visible = true;
                        listBox3.Visible = true;
                        listBox4.Visible = true;
                        listBox7.Visible = true;
                        break;
                    case 5:
                        comboBox6.Visible = true;
                        comboBox7.Visible = true;
                        comboBox8.Visible = true;
                        comboBox9.Visible = true;
                        comboBox10.Visible = true;
                        comboBox1.Visible = true;
                        comboBox2.Visible = true;
                        comboBox3.Visible = true;
                        comboBox4.Visible = true;
                        comboBox5.Visible = true;
                        listBox1.Visible = true;
                        listBox10.Visible = true;
                        listBox2.Visible = true;
                        listBox9.Visible = true;
                        listBox3.Visible = true;
                        listBox8.Visible = true;
                        listBox4.Visible = true;
                        listBox7.Visible = true;
                        listBox6.Visible = true;
                        listBox5.Visible = true;

                        break;
                }
            }
            
            List<string> fabricantes = new List<string>();
            fabricantes.Add("Apple");
            fabricantes.Add("Pepsi");
            fabricantes.Add("CocaCola");
            fabricantes.Add("P&G");
            fabricantes.Add("Microsoft");
            fabricantes.Add("Sony");
            fabricantes.Add("Nestle");
            listBox1.DataSource = fabricantes;
            listBox2.DataSource = fabricantes;
            listBox3.DataSource = fabricantes;
            listBox4.DataSource = fabricantes;
            listBox5.DataSource = fabricantes;
            string item = listBox1.Items[listBox1.SelectedIndex].ToString();

            List<string> productosApple = new List<string>();
            productosApple.Add("Iphone13");
            productosApple.Add("Iphone12");
            productosApple.Add("Iphone11");
            productosApple.Add("Iphone10");
            productosApple.Add("Ipad");
            List<string> productosPepsi = new List<string>();
            productosPepsi.Add("Pepsi3L");
            productosPepsi.Add("Pepsi2L");
            productosPepsi.Add("Pepsi1.5L");
            List<string> productosCoca = new List<string>();
            productosCoca.Add("CocaCola3L");
            productosCoca.Add("Cocacola2L");
            productosCoca.Add("Cocacola1.5L");
            List<string> productosSony = new List<string>();
            productosSony.Add("PS5");
            productosSony.Add("PS4");
            productosSony.Add("JUEGO PS5");
            productosSony.Add("JUEGOPS4");
            productosSony.Add("PS5");

            if (listBox1.SelectedItems.Contains("Apple"))
            {
                listBox10.DataSource = productosApple;

            }
           
            if (listBox2.SelectedItems.Contains("Apple"))
            {
                listBox9.DataSource = productosApple;

            }
            if (listBox3.SelectedItems.Contains("Apple"))
            {
                listBox8.DataSource = productosApple;

            }
            if (listBox4.SelectedItems.Contains("Apple"))
            {
                listBox7.DataSource = productosApple;

            }
            if (listBox5.SelectedItems.Contains("Apple"))
            {
                listBox6.DataSource = productosApple;

            }

            if (listBox1.SelectedItems.Contains("Pepsi"))
            {
                listBox10.DataSource = productosPepsi;

            }
            if (listBox2.SelectedItems.Contains("Pepsi"))
            {
                listBox9.DataSource = productosPepsi;

            }
            if (listBox3.SelectedItems.Contains("Pepsi"))
            {
                listBox8.DataSource = productosPepsi;

            }
            if (listBox4.SelectedItems.Contains("Pepsi"))
            {
                listBox7.DataSource = productosPepsi;

            }
            if (listBox5.SelectedItems.Contains("Pepsi"))
            {
                listBox6.DataSource = productosPepsi;

            }









        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //string item =listBox1.Items[listBox1.SelectedIndex].ToString();
            
           
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //if (comboBox3.SelectedIndex == comboBox3.FindStringExact("Apple"))
          
        }
    }
}
