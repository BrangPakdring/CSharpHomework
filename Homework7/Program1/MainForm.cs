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

            //            this.orderBindingSource.DataSource = orderService.List;

            this.orderBindingSource.DataSource = orderService._list;
 //           this.orderDataGridView.DataSource = orderService._list;

            //            this.orderServiceBindingSource.DataMember = "List";

//            this.orderDataGridView.DataSource = orderService._list;
            
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            /*           Order order = new Order(new Client("HAHA"));
                        order.AddOrderDetails(new OrderDetails(new Product("JJ", 113), 11));
                        order.AddOrderDetails(new OrderDetails(new Product("KK", 114), 22));
                        orderService.AddOrder(order);

                        this.orderDataGridView.Update();*/

            Order order = new Order(new Client("HAHA"));
            order.AddOrderDetails(new OrderDetails(new Product("JJ", 113), 11));
            order.AddOrderDetails(new OrderDetails(new Product("KK", 114), 22));

            if (e is AddingNewEventArgs)
            (e as AddingNewEventArgs).NewObject = order;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            orderDataGridView.DataSource = orderBindingSource;
            this.orderBindingSource.AddingNew+=new AddingNewEventHandler(addOrderButton_Click);
        }

        void testBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            Order order = new Order(new Client("HAHA"));
            order.AddOrderDetails(new OrderDetails(new Product("JJ", 113), 11));
            order.AddOrderDetails(new OrderDetails(new Product("KK", 114), 22));

            e.NewObject = order;
        }
    }
}
