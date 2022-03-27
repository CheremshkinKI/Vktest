using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Vktest.Views
{
    public interface IGrid
    {
        internal void Draw(Graphics g, int x, int y, int width, int heigth, string timeText, string contentText)
        {
            //Основа
            g.FillRectangle(Brushes.Azure, x, y, width, heigth);
            g.DrawRectangle(Pens.Black, x, y, width, heigth);
            g.DrawString(timeText, new Font("Arial", 15), Brushes.Blue, x + 2, y + 2);
            g.DrawString(contentText, new Font("Arial", 15), Brushes.Blue, x + 1, y + 25);
        }
    }

}
