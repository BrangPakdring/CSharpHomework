using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
	static class Program
	{
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();

		internal static Form mainForm;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Test();
			SetProcessDPIAware();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(mainForm = new MainForm());
		}

		static void Test()
		{
			string id;
			Order order = new Order(new Client("Mur"));
			using (var db = new OrderDb())
			{
				id = order.Id;
				OrderDetails details = new OrderDetails(DateTime.Now.Ticks.ToString(), "Egg", 1);
				order.AddOrderDetails(details);
				OrderDetails details2 = new OrderDetails(DateTime.Now.Ticks.ToString(), "Plant", 2);
				order.AddOrderDetails(details2);

				db.Orders.Add(order);
				db.SaveChanges();
			}

			using (var db = new OrderDb())
			{
				var tmp = db.Orders.Include("List").SingleOrDefault(o => o.Id == id);
				Console.WriteLine(tmp);
			}



			using (var db = new OrderDb())
			{
				db.Orders.Attach(order);
				order.Client = new Client("Yajusp");
				db.Entry(order).State = System.Data.Entity.EntityState.Modified;
				order.List.ForEach(i => db.Entry(i).State = System.Data.Entity.EntityState.Modified);
				db.SaveChanges();
			}

			using (var db = new OrderDb())
			{
				foreach(var c in db.Clients)
				{
					Console.WriteLine(c);
				}
				try
				{
					var order1 = db.Orders.Include("List").SingleOrDefault(o => o.Id == id);
					Console.WriteLine(order1);

					db.OrderDetails.RemoveRange(order1.List);
					db.Orders.Remove(order1);

					db.SaveChanges();
				}
				catch (DbEntityValidationException e)
				{
					foreach (var eve in e.EntityValidationErrors)
					{
						Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
							eve.Entry.Entity.GetType().Name, eve.Entry.State);
						foreach (var ve in eve.ValidationErrors)
						{
							Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
								ve.PropertyName,
								eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
								ve.ErrorMessage);
						}
					}
					throw;
				}
			}
		}
	}
}
