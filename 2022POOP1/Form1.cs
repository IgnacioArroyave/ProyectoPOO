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
            fabricantes.Add("Apple");
            fabricantes.Add("Pepsi");
            fabricantes.Add("CocaCola");
            fabricantes.Add("P&G");
            fabricantes.Add("Microsoft");
            fabricantes.Add("Sony");
            fabricantes.Add("Nestle");

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            foreach(string marca in fabricantes)
            {
                listBox1.Items.Add(marca);
                listBox2.Items.Add(marca);
                listBox3.Items.Add(marca);
                listBox4.Items.Add(marca);
                listBox5.Items.Add(marca);
            }


            productosApple.Add("Iphone13");
            productosApple.Add("Iphone12");
            productosApple.Add("Iphone11");
            productosApple.Add("Iphone10");
            productosApple.Add("Ipad");

            productosPepsi.Add("Pepsi3L");
            productosPepsi.Add("Pepsi2L");
            productosPepsi.Add("Pepsi1.5L");

            productosCoca.Add("CocaCola3L");
            productosCoca.Add("Cocacola2L");
            productosCoca.Add("Cocacola1.5L");

            productosSony.Add("PS5");
            productosSony.Add("PS4");
            productosSony.Add("JUEGO PS5");
            productosSony.Add("JUEGOPS4");
            productosSony.Add("PS5");

        }
        List<string> fabricantes = new List<string>();
        List<string> productosApple = new List<string>();
        List<string> productosPepsi = new List<string>();
        List<string> productosCoca = new List<string>();
        List<string> productosSony = new List<string>();

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
            switch (listBox1.Items[listBox1.SelectedIndex])
            {
                case "Apple":
                    listBox10.Items.Clear();
                    foreach (string producto in productosApple)
                        listBox10.Items.Add(producto);
                    break;
                case "Pepsi":
                    listBox10.Items.Clear();
                    foreach (string producto in productosPepsi)
                        listBox10.Items.Add(producto);
                    break;
                case "CocaCola":
                    listBox10.Items.Clear();
                    foreach (string producto in productosCoca)
                        listBox10.Items.Add(producto);
                    break;
                case "Sony":
                    listBox10.Items.Clear();
                    foreach (string producto in productosSony)
                        listBox10.Items.Add(producto);
                    break;
            }
            

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //if (comboBox3.SelectedIndex == comboBox3.FindStringExact("Apple"))
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox2.Items[listBox2.SelectedIndex])
            {
                case "Apple":
                    listBox9.Items.Clear();
                    foreach (string producto in productosApple)
                        listBox9.Items.Add(producto);
                    break;
                case "Pepsi":
                    listBox9.Items.Clear();
                    foreach (string producto in productosPepsi)
                        listBox9.Items.Add(producto);
                    break;
                case "CocaCola":
                    listBox9.Items.Clear();
                    foreach (string producto in productosCoca)
                        listBox9.Items.Add(producto);
                    break;
                case "Sony":
                    listBox9.Items.Clear();
                    foreach (string producto in productosSony)
                        listBox9.Items.Add(producto);
                    break;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox3.Items[listBox3.SelectedIndex])
            {
                case "Apple":
                    listBox8.Items.Clear();
                    foreach (string producto in productosApple)
                        listBox8.Items.Add(producto);
                    break;
                case "Pepsi":
                    listBox8.Items.Clear();
                    foreach (string producto in productosPepsi)
                        listBox8.Items.Add(producto);
                    break;
                case "CocaCola":
                    listBox8.Items.Clear();
                    foreach (string producto in productosCoca)
                        listBox8.Items.Add(producto);
                    break;
                case "Sony":
                    listBox8.Items.Clear();
                    foreach (string producto in productosSony)
                        listBox8.Items.Add(producto);
                    break;
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox4.Items[listBox4.SelectedIndex])
            {
                case "Apple":
                    listBox7.Items.Clear();
                    foreach (string producto in productosApple)
                        listBox7.Items.Add(producto);
                    break;
                case "Pepsi":
                    listBox7.Items.Clear();
                    foreach (string producto in productosPepsi)
                        listBox7.Items.Add(producto);
                    break;
                case "CocaCola":
                    listBox7.Items.Clear();
                    foreach (string producto in productosCoca)
                        listBox7.Items.Add(producto);
                    break;
                case "Sony":
                    listBox7.Items.Clear();
                    foreach (string producto in productosSony)
                        listBox7.Items.Add(producto);
                    break;
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox5.Items[listBox5.SelectedIndex])
            {
                case "Apple":
                    listBox6.Items.Clear();
                    foreach (string producto in productosApple)
                        listBox6.Items.Add(producto);
                    break;
                case "Pepsi":
                    listBox6.Items.Clear();
                    foreach (string producto in productosPepsi)
                        listBox6.Items.Add(producto);
                    break;
                case "CocaCola":
                    listBox6.Items.Clear();
                    foreach (string producto in productosCoca)
                        listBox6.Items.Add(producto);
                    break;
                case "Sony":
                    listBox6.Items.Clear();
                    foreach (string producto in productosSony)
                        listBox6.Items.Add(producto);
                    break;
            }
        }
    }
}
