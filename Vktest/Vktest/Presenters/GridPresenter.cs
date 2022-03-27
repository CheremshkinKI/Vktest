using System;
using System.Collections.Generic;
using System.Text;
using Vktest.Models;
using Vktest.Views;
using System.Drawing;
namespace Vktest.Presenters
{
    public class GridPresenter
    {
        IGrid igrid;
        public GridPresenter(IGrid view)
        {
            igrid = view;
        }
        public void Area(Graphics g)
        {
            int yy = 0;
            int xx = 0;
            int sizet = Grid.getsizebd();
            Grid grid = new Grid();
            for (int i = 1; i <= sizet; i++)
            {
                grid.addDat(i);
                grid.content = "content: " + grid.content;
                grid.time = "time: " + grid.time;
                grid.width = 125;
                grid.heigth = 50;
                grid.x = 5 + xx;
                xx += 135;
                grid.y = 5 + yy;
                igrid.Draw(g, grid.x, grid.y, grid.width, grid.heigth, grid.time, grid.content);
                if (i % 5 == 0)
                {
                    xx = 0;
                    yy += 70;
                }
            }
        }
    }
}
