using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ9_12.View
{
    public interface IView
    {
        string Number1 { get; }
        string Number2 { get; }
        void ShowResult(string result);

        event EventHandler AddClicked;
        event EventHandler SubClicked;
        event EventHandler MulClicked;
        event EventHandler DivClicked;
    }
}
