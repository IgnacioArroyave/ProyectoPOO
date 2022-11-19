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