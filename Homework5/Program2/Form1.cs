using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // default values:
            graphics = DrawingPanel.CreateGraphics();
            ClearAndDrawCheckBox.Checked = true;
            ColorComboBox.SelectedIndex = ColorComboBox.Items.IndexOf("Black");
            Th1OffsetTrackBar.Value = (int)(30 * Math.PI / 2);
            Th2OffsetTrackBar.Value = (int)(20 * Math.PI / 2);
            Per1OffsetTrackBar.Value = 6;
            Per2OffsetTrackBar.Value = 7;
            KOffsetTrackBar.Value = 100;
            TreeDepthNumericUpDown.Value = 10;
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            if (ClearAndDrawCheckBox.Checked==true) graphics?.Clear(SystemColors.Control);
            DrawCayleyTree(TreeDepthNumericUpDown.Value, 350, 350, 100, -Math.PI / 2, (double)KOffsetTrackBar.Value / 100);
        }

        private Random random = new Random();
        private Graphics graphics;
        private Color color;
        double Th1 => Th1OffsetTrackBar.Value * Math.PI / 180;
        double Th2 => Th2OffsetTrackBar.Value * Math.PI / 180;
        double Per1 => (double)Per1OffsetTrackBar.Value / 10;
        double Per2 => (double)Per2OffsetTrackBar.Value / 10;

        void DrawCayleyTree(decimal n,
                double x0, double y0, double leng, double th, double k)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            var x2 = x0 + leng * k * Math.Cos(th);
            var y2 = y0 + leng * k * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);
            DrawLine(x0, y0, x2, y2);

            DrawCayleyTree(n - 1, x1, y1, Per1 * leng, th + Th1, k);
            DrawCayleyTree(n - 1, x2, y2, Per2 * leng, th - Th2, k);
        }

        void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                new Pen(color, (float)WidthNumericUpDown.Value),
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            graphics?.Clear(SystemColors.Control);
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ColorComboBox.Text)
            {
                case "Black":
                    color = Color.Black;
                    break;
                case "Red":
                    color = Color.Red;
                    break;
                case "Green":
                    color = Color.Green;
                    break;
                case "Blue":
                    color = Color.Blue;
                    break;
                default:
                    color = SystemColors.Control;
                    break;
            }
        }

        private void RandomlyGenerateButton_Click(object sender, EventArgs e)
        {
            RandomlyAssign(Th1OffsetTrackBar);
            RandomlyAssign(Th2OffsetTrackBar);
            RandomlyAssign(Per1OffsetTrackBar);
            RandomlyAssign(Per2OffsetTrackBar);
            RandomlyAssign(KOffsetTrackBar);
            Draw_Click(this, null);
        }

        private void RandomlyAssign<T>(T o)
        {
            var t = typeof(T);
            var value = t.GetProperty("Value");
            var min = t.GetProperty("Minimum");
            var max = t.GetProperty("Maximum");
            if (value == null || min==null||max== null) throw new Exception();
            value.SetValue(o, random.Next((int)min.GetValue(o), (int)max.GetValue(o)));
        }
    }
}
