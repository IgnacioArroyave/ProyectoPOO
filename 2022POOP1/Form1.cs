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


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            productosApple.Add(new producto("Iphone13", 2.8f));
            productosApple.Add(new producto("Iphone12", 3.15f));
            productosApple.Add(new producto ("Iphone11", 3.73f));
            productosApple.Add(new producto ("Iphone10", 5.15f));
            productosApple.Add(new producto ("Ipad", 6.67f));

            productosPepsi.Add(new producto("Pepsi3L",0.0525f));
            productosPepsi.Add(new producto("Pepsi2L",0.0350f));
            productosPepsi.Add(new producto("Pepsi1.5L",0.0215f));

            productosCoca.Add(new producto ("Cocacola3L", 0.0525f));
            productosCoca.Add(new producto ("Cocacola2L", 0.0350f));
            productosCoca.Add(new producto ("Cocacola1.5L", 0.0215f));


            productosSony.Add(new producto("PS4", 1.22f));
            productosSony.Add(new producto("PS5", 1.10f));
            productosSony.Add(new producto("JUEGO PS4", 0.002f));
            productosSony.Add(new producto("JUEGO PS5", 0.001f));
            productosSony.Add(new producto("XM4", 0.92f));

            productosMicrosoft.Add(new producto("XBOX1", 1.23f));           
            productosMicrosoft.Add(new producto("Surface laptop1", 0.152f));
            productosMicrosoft.Add(new producto("Surface laptop2", 0.130f));
            productosMicrosoft.Add(new producto("XBOX series S", 1.05f));
            productosMicrosoft.Add(new producto("XBOX series X", 1.12f));
            productosMicrosoft.Add(new producto("Lumia650", 0.36f));
            productosMicrosoft.Add(new producto("Lumia950", 0.52f));

            productosNestle.Add(new producto("Milo 400g",0.0125f));
            productosNestle.Add(new producto("Milo 800g", 0.0225f));
            productosNestle.Add(new producto("Barra Crunch 90g",0.0098f));
            productosNestle.Add(new producto("Barra Crunch 150g",0.0105f));
            productosNestle.Add(new producto("Cerelac 400g",0.0132f));
            productosNestle.Add(new producto("Cerelac 800g",0.0224f));
            productosNestle.Add(new producto("Nescafe 200g", 0.0085f));
            productosNestle.Add(new producto("Nescafe 400g",0.0170f));

            productosPG.Add(new producto("Pantene 500g",0.0175f));
            productosPG.Add(new producto("Pantene 250g", 0.0110f));
            productosPG.Add(new producto("Tidepods 500g",0.0132f));
            productosPG.Add(new producto("OralB 200g",0.0078f));
            productosPG.Add(new producto("OralB 50g",0.0035f));
            productosPG.Add(new producto("Losion Lacoste 500mg",0.0116f));
            productosPG.Add(new producto("Losion Lacoste 250mg",0.0089f));
            productosPG.Add(new producto("Vicks vaporub 50ml",0.0025f));
            productosPG.Add(new producto("Vicks vaporub 100ml",0.0075f));
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

            fabricantes.Add(new fabricante(22.5f, "Apple", productosApple));
            fabricantes.Add(new fabricante(13.8f, "Microsoft", productosMicrosoft));
            fabricantes.Add(new fabricante(113.5f, "Nestle", productosNestle));
            fabricantes.Add(new fabricante(18.47f, "Sony", productosSony));
            fabricantes.Add(new fabricante(2.4f, "PG", productosPG));
            fabricantes.Add(new fabricante(63.1f, "Pepsi", productosPepsi));
            fabricantes.Add(new fabricante(5.17f, "CocaCola", productosCoca));

            foreach (fabricante marca in fabricantes)
            {
                listBox1.Items.Add(marca.nombre);
                listBox2.Items.Add(marca.nombre);
                listBox3.Items.Add(marca.nombre);
                listBox4.Items.Add(marca.nombre);
                listBox5.Items.Add(marca.nombre);
            }
        }
        List<fabricante> fabricantes = new List<fabricante>();
        List<producto> productosApple = new List<producto>();
        List<producto> productosPepsi = new List<producto>();
        List<producto> productosCoca = new List<producto>();
        List<producto> productosSony = new List<producto>();
        List<producto> productosMicrosoft = new List<producto>();
        List<producto> productosNestle = new List<producto>();
        List<producto> productosPG = new List<producto>();
        List<ListBox> faber = new List<ListBox>();
        List<ListBox> remolino = new List<ListBox>();





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
            for (int i = 0; i < numericUpDown1.Value; i++)
            {

                if (faber[i].SelectedIndex == -1)
                {
                    continue;
                }
                string nombre_fabricante = faber[i].Items[faber[i].SelectedIndex].ToString();
                string nombre_producto = remolino[i].Items[remolino[i].SelectedIndex].ToString();

                fabricante Fabricante = fabricantes[0];
                foreach (fabricante fab in fabricantes)
                {
                    if (fab.nombre == nombre_fabricante)
                        Fabricante = fab;
                }

                float factor = Fabricante.factor;
                float eficiencia = Fabricante.getEficiencia(nombre_producto);

                total += factor * eficiencia;
            }
            MessageBox.Show("su huella de carbono es:" + "\n" + total+"T/CO2");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string item =listBox1.Items[listBox1.SelectedIndex].ToString();
            switch (listBox1.Items[listBox1.SelectedIndex])
            {
                case "Apple":
                    listBox10.Items.Clear();
                    foreach (producto prod in productosApple)
                        listBox10.Items.Add(prod.nombre);
                    break;
                case "Pepsi":
                    listBox10.Items.Clear();
                    foreach (producto prod in productosPepsi)
                        listBox10.Items.Add(prod.nombre);
                    break;
                case "CocaCola":
                    listBox10.Items.Clear();
                    foreach (producto prod in productosCoca)
                        listBox10.Items.Add(prod.nombre);
                    break;
                case "Sony":
                    listBox10.Items.Clear();
                    foreach (producto prod in productosSony)
                        listBox10.Items.Add(prod.nombre);
                    break;
                case "Microsoft":
                    listBox10.Items.Clear();
                    foreach (producto prod in productosMicrosoft)
                        listBox10.Items.Add(prod.nombre);
                    break;
                case "Nestle":
                    listBox10.Items.Clear();
                    foreach (producto prod in productosNestle)
                        listBox10.Items.Add(prod.nombre);
                    break;
                case "PG":
                    listBox10.Items.Clear();
                    foreach (producto prod in productosPG)
                        listBox10.Items.Add(prod.nombre);
                    break;
            }
            

        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox2.Items[listBox2.SelectedIndex])
            {
                case "Apple":
                    listBox9.Items.Clear();
                    foreach (producto prod in productosApple)
                        listBox9.Items.Add(prod.nombre);
                    break;
                case "Pepsi":
                    listBox9.Items.Clear();
                    foreach (producto prod in productosPepsi)
                        listBox9.Items.Add(prod.nombre);
                    break;
                case "CocaCola":
                    listBox9.Items.Clear();
                    foreach (producto prod in productosCoca)
                        listBox9.Items.Add(prod.nombre);
                    break;
                case "Sony":
                    listBox9.Items.Clear();
                    foreach (producto prod in productosSony)
                        listBox9.Items.Add(prod.nombre);
                    break;
                case "Microsoft":
                    listBox9.Items.Clear();
                    foreach (producto prod in productosMicrosoft)
                        listBox9.Items.Add(prod.nombre);
                    break;
                case "Nestle":
                    listBox9.Items.Clear();
                    foreach (producto prod in productosNestle)
                        listBox9.Items.Add(prod.nombre);
                    break;
                case "PG":
                    listBox9.Items.Clear();
                    foreach (producto prod in productosPG)
                        listBox9.Items.Add(prod.nombre);
                    break;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox3.Items[listBox3.SelectedIndex])
            {
                case "Apple":
                    listBox8.Items.Clear();
                    foreach (producto prod in productosApple)
                        listBox8.Items.Add(prod.nombre);
                    break;
                case "Pepsi":
                    listBox8.Items.Clear();
                    foreach (producto prod in productosPepsi)
                        listBox8.Items.Add(prod.nombre);
                    break;
                case "CocaCola":
                    listBox8.Items.Clear();
                    foreach (producto prod in productosCoca)
                        listBox8.Items.Add(prod.nombre);
                    break;
                case "Sony":
                    listBox8.Items.Clear();
                    foreach (producto prod in productosSony)
                        listBox8.Items.Add(prod.nombre);
                    break;
                case "Microsoft":
                    listBox8.Items.Clear();
                    foreach (producto prod in productosMicrosoft)
                        listBox8.Items.Add(prod.nombre);
                    break;
                case "Nestle":
                    listBox8.Items.Clear();
                    foreach (producto prod in productosNestle)
                        listBox8.Items.Add(prod.nombre);
                    break;
                case "PG":
                    listBox8.Items.Clear();
                    foreach (producto prod in productosPG)
                        listBox8.Items.Add(prod.nombre);
                    break;
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox4.Items[listBox4.SelectedIndex])
            {
                case "Apple":
                    listBox7.Items.Clear();
                    foreach (producto prod in productosApple)
                        listBox7.Items.Add(prod.nombre);
                    break;
                case "Pepsi":
                    listBox7.Items.Clear();
                    foreach (producto prod in productosPepsi)
                        listBox7.Items.Add(prod.nombre);
                    break;
                case "CocaCola":
                    listBox7.Items.Clear();
                    foreach (producto prod in productosCoca)
                        listBox7.Items.Add(prod.nombre);
                    break;
                case "Sony":
                    listBox7.Items.Clear();
                    foreach (producto prod in productosSony)
                        listBox7.Items.Add(prod.nombre);
                    break;
                case "Microsoft":
                    listBox7.Items.Clear();
                    foreach (producto prod in productosMicrosoft)
                        listBox7.Items.Add(prod.nombre);
                    break;
                case "Nestle":
                    listBox7.Items.Clear();
                    foreach (producto prod in productosNestle)
                        listBox7.Items.Add(prod.nombre);
                    break;
                case "PG":
                    listBox7.Items.Clear();
                    foreach (producto prod in productosPG)
                        listBox7.Items.Add(prod.nombre);
                    break;
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox5.Items[listBox5.SelectedIndex])
            {
                case "Apple":
                    listBox6.Items.Clear();
                    foreach (producto prod in productosApple)
                        listBox6.Items.Add(prod.nombre);
                    break;
                case "Pepsi":
                    listBox6.Items.Clear();
                    foreach (producto prod in productosPepsi)
                        listBox6.Items.Add(prod.nombre);
                    break;
                case "CocaCola":
                    listBox6.Items.Clear();
                    foreach (producto prod in productosCoca)
                        listBox6.Items.Add(prod.nombre);
                    break;
                case "Sony":
                    listBox6.Items.Clear();
                    foreach (producto prod in productosSony)
                        listBox6.Items.Add(prod.nombre);
                    break;
                case "Microsoft":
                    listBox6.Items.Clear();
                    foreach (producto prod in productosMicrosoft)
                        listBox6.Items.Add(prod.nombre);
                    break;
                case "Nestle":
                    listBox6.Items.Clear();
                    foreach (producto prod in productosNestle)
                        listBox6.Items.Add(prod.nombre);
                    break;
                case "PG":
                    listBox6.Items.Clear();
                    foreach (producto prod in productosPG)
                        listBox6.Items.Add(prod.nombre);
                    break;
            }
        }
    }
}

public class fabricante
{
    public fabricante(float Factor_, string Nombre_, List<producto> Productos)
    {
        factor = Factor_;
        nombre = Nombre_;
        productos = Productos;
    }

    public List<producto> productos;
    private float Factor;
    public float factor
    {
        get
        {
            return Factor;
        }
        private set { Factor = value; }
    }
    private string Nombre;
    public string nombre
    {
        get
        {
            return Nombre;
        }
        private set { Nombre = value; }
    }

    public float getEficiencia(string nombre)
    {
        foreach (producto prod in productos)
            if (nombre == prod.nombre)
                return prod.eficiencia;
        return 0;
    }
}

public class producto
{
    public producto(string Nombre, float Eficiencia)
    {
        eficiencia = Eficiencia;
        nombre = Nombre;
    }
    private float Eficiencia;
    public float eficiencia
    {
        get
        {
            return Eficiencia;
        }
        private set { Eficiencia = value; }
    }

    private string Nombre;
    public string nombre
    {
        get
        {
            return Nombre;
        }
        private set { Nombre = value; }
    }

}