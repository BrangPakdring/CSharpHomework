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
    public partial class Form1 : Form
    {
        private OrderService orderService;
        private List<Order> orders;
        BindingSource bindingSource;

        public Form1()
        {
            bindingSource = new BindingSource();

            orderService = OrderService.GetInstance();
//            orderService.ClearStatus();
            orders = orderService.GetList();

            InitializeComponent();
            
            this.bindingSource.DataSource = orders;

            this.dataGridView2.DataSource = orders;
 //           this.dataGridView2.DataMember = "orders";
        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderService.AddOrder(new Order(new Client("haha")));
            Order order = new Order(new Client("fefe"));
            order.AddOrderDetails(new OrderDetails(new Product("haha", 114514)));
            order.AddOrderDetails(new OrderDetails(new Product("jjjj", 810)));
            orderService.AddOrder(order);
            this.dataGridView2.DataSource = orderService.GetList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
