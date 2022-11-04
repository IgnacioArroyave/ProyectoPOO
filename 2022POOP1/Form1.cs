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
            fabricantes.Add("PG");
            fabricantes.Add("Microsoft");
            fabricantes.Add("Sony");
            fabricantes.Add("Nestle");

            factores.Add("Apple", 22.5f);
            factores.Add("Microsoft", 13.8f);
            factores.Add("Nestle", 113.5f);
            factores.Add("Sony", 18.47f);
            factores.Add("PG", 2.4f);
            factores.Add("Pepsi", 63.1f);
            factores.Add("Coca", 5.17f);

            EAPPLE.Add("Iphone13",2.8f);
            EAPPLE.Add("Iphone12", 3.15f);
            EAPPLE.Add("Iphone11", 3.73f);
            EAPPLE.Add("Iphone10", 5.15f);
            EAPPLE.Add("Ipad", 6.67f);

            EMICRO.Add("XBOX1", 1.23f);
            EMICRO.Add("Surface laptop1", 0.152f);
            EMICRO.Add("Surface laptop2", 0.130f);
            EMICRO.Add("XBOX series S", 1.05f);
            EMICRO.Add("XBOX series X", 1.12f);
            EMICRO.Add("Lumia650", 0.36f);
            EMICRO.Add("Lumia950", 0.52f);

            EPEPSI.Add("Pepsi3L", 0.0525f);
            EPEPSI.Add("Pepsi2L", 0.0350f);
            EPEPSI.Add("Pepsi1.5L", 0.0215f);

            ECOCA.Add("Cocacola3L", 0.0525f);
            ECOCA.Add("Cocacola2L", 0.0350f);
            ECOCA.Add("Cocacola1.5L", 0.0215f);

            ESONY.Add("PS4", 1.22f);
            ESONY.Add("PS5", 1.10f);
            ESONY.Add("JUEGO PS4", 0.002f);
            ESONY.Add("JUEGO PS5", 0.001f);
            ESONY.Add("XM4", 0.92f);





            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            


            foreach (string marca in fabricantes)
            {
                listBox1.Items.Add(marca);
                listBox2.Items.Add(marca);
                listBox3.Items.Add(marca);
                listBox4.Items.Add(marca);
                listBox5.Items.Add(marca);
            }

            //Allan Paniagua
            productosApple.Add("Iphone13");
            productosApple.Add("Iphone12");
            productosApple.Add("Iphone11");
            productosApple.Add("Iphone10");
            productosApple.Add("Ipad");

            productosPepsi.Add("Pepsi3L");
            productosPepsi.Add("Pepsi2L");
            productosPepsi.Add("Pepsi1.5L");

            productosCoca.Add("Cocacola3L");
            productosCoca.Add("Cocacola2L");
            productosCoca.Add("Cocacola1.5L");

            productosSony.Add("PS5");
            productosSony.Add("PS4");
            productosSony.Add("JUEGO PS5");
            productosSony.Add("JUEGOPS4");
            productosSony.Add("SONY XM4");

            productosMicrosoft.Add("XBOX1");
            productosMicrosoft.Add("Surface laptop1");
            productosMicrosoft.Add("Surface laptopt2");
            productosMicrosoft.Add("XBOX series S");
            productosMicrosoft.Add("XBOX series X");
            productosMicrosoft.Add("Lumia650");
            productosMicrosoft.Add("Lumia950");

            productosNestle.Add("Milo 400g");
            productosNestle.Add("Milo 800g");
            productosNestle.Add("Barra Crunch 90g");
            productosNestle.Add("Barra Crunch 150g");
            productosNestle.Add("Cerelac 400g");
            productosNestle.Add("Cerelac 800g");
            productosNestle.Add("Nescafe 200g");
            productosNestle.Add("Nescafe 400g");

            productosPG.Add("Pantene 500g");
            productosPG.Add("Pantene 250g");
            productosPG.Add("Tidepods 500g");
            productosPG.Add("OralB 200g");
            productosPG.Add("OralB 50g");
            productosPG.Add("Losion Lacoste 500mg");
            productosPG.Add("Losion Lacoste 250mg");
            productosPG.Add("Vicks vaporub 50ml");
            productosPG.Add("Vicks vaporub 100ml");
            //
            faber.Add(listBox1);
            faber.Add(listBox2);
            faber.Add(listBox3);
            faber.Add(listBox4);
            faber.Add(listBox5);

            remolino.Add(listBox10);
            remolino.Add(listBox9);
            remolino.Add(listBox8);
            remolino.Add(listBox7);
            remolino.Add(listBox6);
            
        }
        List<string> fabricantes = new List<string>();
        List<string> productosApple = new List<string>();
        List<string> productosPepsi = new List<string>();
        List<string> productosCoca = new List<string>();
        List<string> productosSony = new List<string>();
        List<string> productosMicrosoft = new List<string>();
        List<string> productosNestle = new List<string>();
        List<string> productosPG = new List<string>();
        List<ListBox> faber = new List<ListBox>();
        List<ListBox> remolino = new List<ListBox>();
        Dictionary<string, float> factores = new Dictionary<string, float>();
        Dictionary<string, float> EAPPLE = new Dictionary<string, float>();
        Dictionary<string, float> EMICRO = new Dictionary<string, float>();
        Dictionary<string, float> ESONY = new Dictionary<string, float>();
        Dictionary<string, float> ENEST = new Dictionary<string, float>();
        Dictionary<string, float> EPG = new Dictionary<string, float>();
        Dictionary<string, float> ECOCA = new Dictionary<string, float>();
        Dictionary<string, float> EPEPSI = new Dictionary<string, float>();


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
            float total = 0;
            for (int i = 0; i < numericUpDown1.Value - 1; i++)
            {


                string fabricante = faber[i].Items[faber[i].SelectedIndex].ToString();
                string producto = remolino[i].Items[remolino[i].SelectedIndex].ToString();


                float factor = factores[fabricante];
                float eficiencia = 0;

                switch (fabricante)
                {
                    case "Apple":
                        eficiencia = EAPPLE[producto];
                        break;

                    case "Sony":
                        eficiencia = ESONY[producto];
                        break;

                    case "Microsoft":
                        eficiencia = EMICRO[producto];
                        break;

                    case "Nestle":
                        eficiencia = ENEST[producto];
                        break;

                    case "PG":
                        eficiencia = EPG[producto];
                        break;

                    case "Coca":
                        eficiencia = ECOCA[producto];
                        break;

                    case "Pepsi":
                        eficiencia = EPEPSI[producto];
                        break;
                }
                total += factor * eficiencia;
            }
            MessageBox.Show("su huella de carbono es:" + "\n" + total+"T/CO2");
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
                case "Microsoft":
                    listBox10.Items.Clear();
                    foreach (string producto in productosMicrosoft)
                        listBox10.Items.Add(producto);
                    break;
                case "Nestle":
                    listBox10.Items.Clear();
                    foreach (string producto in productosNestle)
                        listBox10.Items.Add(producto);
                    break;
                case "PG":
                    listBox10.Items.Clear();
                    foreach (string producto in productosPG)
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
                case "Microsoft":
                    listBox9.Items.Clear();
                    foreach (string producto in productosMicrosoft)
                        listBox9.Items.Add(producto);
                    break;
                case "Nestle":
                    listBox9.Items.Clear();
                    foreach (string producto in productosNestle)
                        listBox9.Items.Add(producto);
                    break;
                case "PG":
                    listBox9.Items.Clear();
                    foreach (string producto in productosPG)
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
                case "Microsoft":
                    listBox8.Items.Clear();
                    foreach (string producto in productosMicrosoft)
                        listBox8.Items.Add(producto);
                    break;
                case "Nestle":
                    listBox8.Items.Clear();
                    foreach (string producto in productosNestle)
                        listBox8.Items.Add(producto);
                    break;
                case "PG":
                    listBox8.Items.Clear();
                    foreach (string producto in productosPG)
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
                case "Microsoft":
                    listBox7.Items.Clear();
                    foreach (string producto in productosMicrosoft)
                        listBox7.Items.Add(producto);
                    break;
                case "Nestle":
                    listBox7.Items.Clear();
                    foreach (string producto in productosNestle)
                        listBox7.Items.Add(producto);
                    break;
                case "PG":
                    listBox7.Items.Clear();
                    foreach (string producto in productosPG)
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
                case "Microsoft":
                    listBox6.Items.Clear();
                    foreach (string producto in productosMicrosoft)
                        listBox6.Items.Add(producto);
                    break;
                case "Nestle":
                    listBox6.Items.Clear();
                    foreach (string producto in productosNestle)
                        listBox6.Items.Add(producto);
                    break;
                case "PG":
                    listBox6.Items.Clear();
                    foreach (string producto in productosPG)
                        listBox6.Items.Add(producto);
                    break;
            }
        }
    }
}
