using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenAdmision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
        
           dgvLista.Rows.Add(txtNombreLibro.Text, txtAutor.Text, cmbxClasificacion.Text, txtCantidadHojas.Text, DTPFechaLibro.Value, txtPrecioRenta.Text);
         
            txtAutor.Text = "";
            txtNombreLibro.Text = "";
            cmbxClasificacion.Text = "";
            txtCantidadHojas.Text = "";
            DTPFechaLibro.Text = "";
            txtPrecioRenta.Text = "";
            MessageBox.Show("Datos Guardados");

        }

        


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            //if (txtBuscar.Text!="") 
            //{
            //    dgvLista.CurrentCell = null;
            //    foreach(DataGridViewRow r in dgvLista.Rows)
            //    {
            //        //r.Visible = false;
            //    }

            //    foreach (DataGridViewRow r in dgvLista.Rows)
            //    {

            //        foreach (DataGridViewCell c in r.Cells)
            //        {
            //            if (c.Value.ToString().ToUpper().IndexOf(txtBuscar.Text.ToUpper())==0)
            //                {
            //                r.Visible = true;
            //                break;

            //            }
            //        }

            //    }
              
            //}
            //else            
            //{
                
            //}
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
         
            int dia, mes, año;
            int diaR, mesR, añoR;
            int i, j,k;
            int cal,calmes,calaño;
            dia = Convert.ToInt32(DTPFechaProgramada.Value.ToString().Substring(0, 2));
            mes = Convert.ToInt32(DTPFechaProgramada.Value.ToString().Substring(3, 2));
            año = Convert.ToInt32(DTPFechaProgramada.Value.ToString().Substring(6, 4));

            diaR = Convert.ToInt32(DTPEntregaReal.Value.ToString().Substring(0, 2));
            mesR = Convert.ToInt32(DTPEntregaReal.Value.ToString().Substring(3, 2));
            añoR = Convert.ToInt32(DTPEntregaReal.Value.ToString().Substring(6, 4));

            //Conversiones
            cal = diaR - dia;
            calmes = mesR - mes;
            calaño = añoR - año;

            if (cal <= 0 && mesR == mes && añoR == año)
            {
                lblMulta.Text = "No debe Multa";
            }

            if (cal >= 1 && mesR == mes && añoR == año)
            {
                i = cal * 15;
                lblMulta.Text = "Su Multa es de: $" + i+" Pesos";
            }

            if(calmes>=1 && añoR==año)
            {
              k=  calmes * 500;
                lblMulta.Text = "Su Multa es de: $" + k+" Pesos";
            }

            if (calaño >= 1)
            {
                lblMulta.Text = "Su Multa es de: $" + 10000 +" Pesos";
            }

  

        }
    }
    }

