using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace _2022POOP1
{
    public partial class Form1 : Form
    {
        private void cargard()
        {
            string connstring = @"server=127.0.0.1;userid=localhost;password=;database=proyecto";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connstring);
                conn.Open();

                string query = "SELECT * FROM fabricante;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "fabricante");
                DataTable fab = ds.Tables["fabricante"];

                

                foreach (DataRow row in fab.Rows)
                {
                    query = "SELECT * FROM producto where `marca` = " + row["id"] + ";";
                    MySqlDataAdapter da1 = new MySqlDataAdapter(query, conn);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1, "producto");
                    DataTable prod = ds1.Tables["producto"];
                    List<producto> prods = new List<producto>();
                    foreach (DataRow prodrow in prod.Rows)
                        prods.Add(new producto(prodrow["nombre"].ToString(), float.Parse(prodrow["efectividad"].ToString())));

                    fabricantes.Add(new fabricante(float.Parse(row["factor"].ToString()), row["nombre"].ToString(), prods));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public Form1()
        {
            cargard();
            InitializeComponent();


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

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
            MessageBox.Show("su huella de carbono es:" + "\n" + total+"Kg/CO2");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string item =listBox1.Items[listBox1.SelectedIndex].ToString();
            ListBox myListBox = listBox10;
            string nombreFab = listBox1.Items[listBox1.SelectedIndex].ToString();

            //valor default
            fabricante myFaber = new fabricante(0, "Fabricante no encontrado", new List<producto>());

            //busca el fabricante por nombre
            foreach (fabricante fab in fabricantes)
                if (fab.nombre == nombreFab)
                    myFaber = fab;


            myListBox.Items.Clear();
            foreach (producto prod in myFaber.productos)
                myListBox.Items.Add(prod.nombre);
           

        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox myListBox = listBox9;
            string nombreFab = listBox2.Items[listBox2.SelectedIndex].ToString();

            //valor default
            fabricante myFaber = new fabricante(0, "Fabricante no encontrado", new List<producto>());

            //busca el fabricante por nombre
            foreach (fabricante fab in fabricantes)
                if (fab.nombre == nombreFab)
                    myFaber = fab;


            myListBox.Items.Clear();
            foreach (producto prod in myFaber.productos)
                myListBox.Items.Add(prod.nombre);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox myListBox = listBox8;
            string nombreFab = listBox3.Items[listBox3.SelectedIndex].ToString();

            //valor default
            fabricante myFaber = new fabricante(0, "Fabricante no encontrado", new List<producto>());

            //busca el fabricante por nombre
            foreach (fabricante fab in fabricantes)
                if (fab.nombre == nombreFab)
                    myFaber = fab;


            myListBox.Items.Clear();
            foreach (producto prod in myFaber.productos)
                myListBox.Items.Add(prod.nombre);
          
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox myListBox = listBox7;
            string nombreFab = listBox4.Items[listBox4.SelectedIndex].ToString();

            //valor default
            fabricante myFaber = new fabricante(0, "Fabricante no encontrado", new List<producto>());

            //busca el fabricante por nombre
            foreach (fabricante fab in fabricantes)
                if (fab.nombre == nombreFab)
                    myFaber = fab;


            myListBox.Items.Clear();
            foreach (producto prod in myFaber.productos)
                myListBox.Items.Add(prod.nombre);
           
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox myListBox = listBox6;
            string nombreFab = listBox5.Items[listBox5.SelectedIndex].ToString();

            //valor default
            fabricante myFaber = new fabricante(0, "Fabricante no encontrado", new List<producto>());

            //busca el fabricante por nombre
            foreach (fabricante fab in fabricantes)
                if (fab.nombre == nombreFab)
                    myFaber = fab;


            myListBox.Items.Clear();
            foreach (producto prod in myFaber.productos)
                myListBox.Items.Add(prod.nombre);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 formita = new Form1();
            formita.Show();
            this.Dispose(false);
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