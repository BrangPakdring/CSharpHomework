using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program1;

namespace Program1
{
    public partial class MainForm : Form
    {
        private OrderService orderService = OrderService.GetInstance();

        public MainForm()
        {
            InitializeComponent();
            this.orderBindingSource.DataSource = orderService.List;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(new Client("HAHA"));
            order.AddOrderDetails(new OrderDetails(new Product("JJ", 113), 11));
            order.AddOrderDetails(new OrderDetails(new Product("KK", 114), 22));
            orderService.AddOrder(order);
            new AddOrderForm(new Order()).Show();

            orderBindingSource.DataSource = orderService.List;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
