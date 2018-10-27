using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class AddOrderForm : Form
    {
        Order order;

        private AddOrderForm()
        {
            InitializeComponent();
        }

        public AddOrderForm(Order order):this()
        {
            this.order = order;
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            this.costLabel.DataBindings.Add(new Binding("Text", orderDetailsBindingSource, "Cost"));
            this.orderIdLabel.DataBindings.Add(new Binding("Text", order, "Id"));
        }
    }
}
