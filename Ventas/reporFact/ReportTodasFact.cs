using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas.reporFact
{
    public partial class ReportTodasFact : form.FormRepor
    {
        private int id, rol;
        private String nombre;
        public ReportTodasFact()
        {
            InitializeComponent();
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

        private void ReportTodasFact_Load(object sender, EventArgs e)
        {
            CrystalTodasFact1.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Ventas.Menu();
            menu.Id = this.Id;
            menu.Nombre = this.Nombre;
            menu.Rol = this.Rol;
            menu.Show();
        }
    }
}
