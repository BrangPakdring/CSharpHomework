using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter1_Problem5
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var number1 = Number1.Text;
			var number2 = Number2.Text;
			if (number1 == "" || number2 == "")
			{
				Result.Text = "invalid";
			}
			else
			{
				var res = Convert.ToString(double.Parse(number1) * double.Parse(number2));
				Result.Text = res;
			}
		}

		private void Number1_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void Number2_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}
}
