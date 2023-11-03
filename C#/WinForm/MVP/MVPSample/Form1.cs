using MVPSample.Presenters;
using MVPSample.View;
using System;
using System.Windows.Forms;

namespace MVPSample
{
    public partial class Form1 : Form, IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthText { 
            get => txtLength.Text;
            set => txtLength.Text = value; 
        }
        public string BreadthText { 
            get => txtBreadth.Text; 
            set => txtBreadth.Text = value; 
        }
        public string AreaText { 
            get => lblArea.Text;
            set => lblArea.Text = value + " Sq CM";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CaclulateArea();
        }
    }
}
