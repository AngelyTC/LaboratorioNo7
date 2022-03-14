using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LaboratorioNo7
{
    public partial class Form1 : Form
    {

        List<CasasPropietario> registro = new List<CasasPropietario>();
        List<Propietario> persona = new List<Propietario>();
        List<Propiedad> casa = new List<Propiedad>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < persona.Count; ++i)
            {
                CasasPropietario registro2 = new CasasPropietario();

                for (int j = 0; j < casa.Count; j++)
                {
                    if (persona[i].dpi == casa[j].dpi)
                    {
                        registro2.nombre = persona[i].nombre;
                        registro2.apellido= persona[i].apellido;
                        registro2.noCasa = casa[j].NoCasa;
                        registro2.cuotaMant= casa[j].cuotaMant;
                    }

                }
                registro.Add(registro2);
                dgtPropietario.DataSource = null;
                dgtPropietario.Refresh();

                dgtPropietario.DataSource = registro;
                dgtPropietario.Refresh();
            }
        }

        private void LeerCliente()
        {
            FileStream stream = new FileStream("ArchivoPropietario.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1) //el -1 significa la ultima linea que no existe demostrando el final del archivo
            {
               Propietario persona1 = new Propietario();
                persona1.dpi = reader.ReadLine();
                persona1.nombre = reader.ReadLine();
                persona1.apellido = reader.ReadLine();

                //agregar a lista
                persona.Add(persona1);
            }

            reader.Close();
        }

        private void LeerPropiedad()
        {
            FileStream stream = new FileStream("ArchivoPropiedad.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1) //el -1 significa la ultima linea que no existe demostrando el final del archivo
            {
                Propiedad casa1 = new Propiedad();
                casa1.NoCasa = reader.ReadLine();
                casa1.dpi = reader.ReadLine();
                casa1.cuotaMant  = Convert.ToInt32(reader.ReadLine());

                //agregar a lista
                casa.Add(casa1);
            }

            reader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LeerCliente();
            LeerPropiedad();
        }

        private void btnOrdenarCuota_Click(object sender, EventArgs e)
        {
             registro = registro.OrderByDescending(n => n.cuotaMant).ToList();
            dgtPropietario.DataSource = null;
            dgtPropietario.Refresh();

            dgtPropietario.DataSource = registro;
            dgtPropietario.Refresh();
        }

        private void btnCuotas3_Click(object sender, EventArgs e)
        {
            int registrosOrden = registro.Count();
  
           label4.Text = "Cuotas más bajas: " + registro[registrosOrden - 1].cuotaMant.ToString() + " , " + registro[registrosOrden - 2].cuotaMant.ToString() + " , " + registro[registrosOrden - 3].cuotaMant.ToString();

            label6.Text = "Cuotas más altas: " + registro[0].cuotaMant.ToString() + " , " + registro[1].cuotaMant.ToString() + " , " + registro[2].cuotaMant.ToString();

        }

        private void btnPropAlto_Click(object sender, EventArgs e)
        {

           CasasPropietario mostrar2 = new CasasPropietario();
          
                for (int j = 0; j < registro.Count; j++)
                {
                    int mayorCuota = registro.Max(u => u.cuotaMant);
                    label8.Text = "La mayor cuota es de:  " + mayorCuota.ToString();
                    if (mayorCuota == registro[j].cuotaMant)
                    {
                        label9.Text = "del propietario:  " +  registro[j].nombre;
                    }
                }
               
              
        }
    }
}
