using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_camp2._1
{
    public partial class Form1 : Form
    {
        private object rbDescuento;

        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            decimal pension = 0;

            // Asignar pensión base según categoría
            switch (cmbCategoria.Text)
            {
                case "A": pension = 550; break;
                case "B": pension = 500; break;
                case "C": pension = 450; break;
                case "D": pension = 400; break;
                default:
                    MessageBox.Show("Seleccione una categoría.");
                    return;
            }

            // Validar y obtener promedio
            if (!decimal.TryParse(txtPromedio.Text, out decimal promedio) || promedio < 0 || promedio > 20)
            {
                MessageBox.Show("Ingrese un promedio válido entre 0 y 20.");
                return;
            }


            // Calcular descuento
            decimal descuento = 0;
            if (promedio >= 14 && promedio <= 15.99m) descuento = 0.10m;
            else if (promedio >= 16 && promedio <= 17.99m) descuento = 0.15m;
            else if (promedio >= 18 && promedio <= 20) descuento = 0.25m;


            // Aplicar descuento 
    
            {
                pension -= pension * descuento;
            }


            // Mostrar resultado del escuento

            decimal montoDescuento = pension * descuento;
            lblDescuento.Text = $"Descuento : S/. {montoDescuento:F2}";


            // Mostrar resultado en Nueva Pensión
            decimal pensionFinal = pension - (pension * descuento);
            lblNuevaPension.Text = $"Pensión : S/. {pensionFinal:F2}";


        }
    }
}
