using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Program2
{
    public partial class FrmContarloc : Form
    {
        public FrmContarloc()
        {
            InitializeComponent();
        }
         


        String leer;
        public void Cargar()
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "text files (*.txt)|*.txt"; //Filtra unicamente los .txt
            buscar.RestoreDirectory = true; //abre la ultima ubicacion
            if (buscar.ShowDialog() == DialogResult.OK)//Abre el explorador de archivos
            {
                String NumArchivo = buscar.FileName; // Almacenamiento del archivo

                leer = File.ReadAllText(NumArchivo); //Muestra el archivo 
                TxtContenedor.Text = leer;   //En el contenedor

            }
            lblUbicacion.Text = buscar.FileName; //Ver ubicacion

            
}



            //int count = 0;
            //foreach (char item in leer)
            //{
            //    if (item == '/' || item == '/')
            //    {
            //        count++;
            //    }
            //    lblsuma.Text = count.ToString();
            //}

        }

        private void BtnBuscarArchivo_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void FrmContarloc_Load(object sender, EventArgs e)
        {

        }
    }
}
