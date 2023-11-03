using MVPSample.Models;
using MVPSample.View;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPSample.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;

        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }

        public void CaclulateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = double.Parse(rectangleView.LengthText);
            rectangle.Breadth = double.Parse(rectangleView.BreadthText);
            rectangleView.AreaText = rectangle.CaclulateArea().ToString();
        }
    }
}
