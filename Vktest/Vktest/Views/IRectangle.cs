using System;
using System.Collections.Generic;
using System.Text;

namespace Vktest.Views
{
    public interface IRectangle
    {
        string LengthText { get; set; }
        string BreadthText { get; set; }
        string AreaText { get; set; }
    }
}
