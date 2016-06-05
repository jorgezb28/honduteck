using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Honduteck._1._1_Domain.Repositories;

namespace Honduteck
{
    public partial class FormTipoClientes : Form
    {
        private readonly ITipoClienteRepository _tipoClienteRepository;
        public FormTipoClientes(ITipoClienteRepository tipoClienteRepository)
        {
            _tipoClienteRepository = tipoClienteRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_tipoClienteRepository.ToString());
        }
    }
}
