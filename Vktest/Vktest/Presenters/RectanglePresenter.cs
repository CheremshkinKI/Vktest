using System;
using System.Collections.Generic;
using System.Text;
using Vktest.Models;
using Vktest.Views;

namespace Vktest.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleView;
        public RectanglePresenter(IRectangle view)
        {
            rectangleView = view;
        }
        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = double.Parse(rectangleView.LengthText);
            rectangle.Breadth = double.Parse(rectangleView.BreadthText);

            rectangleView.AreaText = rectangle.CalculateArea().ToString();

        }
    }
}
