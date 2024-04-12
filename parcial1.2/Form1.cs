using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dtpsalida.MaxDate = DateTime.Now;
            dtpreserva.MaxDate = dtpsalida.Value.AddDays(-1);
            cmbdest.SelectedIndex = 0;
            cmbdest.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private bool Verificar()
        {
            bool ok = false;
            int num;

            if (mtbcod.MaskCompleted)
            {
                ok =true;
            }
            else
            {
                MessageBox.Show("Casilla de codigo vacia","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtapell.Text.Trim() != string.Empty)
            {
                if(int.TryParse(txtapell.Text,out num))
                {
                    MessageBox.Show("La casilla Apellido solo debe completarse con Letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ok = true;
                }
            }
            else
            {
                MessageBox.Show("Casilla de Apellido vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ok;
        }

    }
}
