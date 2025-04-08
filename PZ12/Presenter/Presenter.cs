using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PZ9_12.View;
using PZ9_12.Model;


namespace PZ9_12.Presenter
{
    public class CPresenter
    {
        private readonly IView view;
        private readonly CModel model;

        public CPresenter(IView view, CModel model)
        {
            this.view = view;
            this.model = model;

            view.AddClicked += (s, e) => Calculate(model.Add);
            view.SubClicked += (s, e) => Calculate(model.Subtract);
            view.MulClicked += (s, e) => Calculate(model.Multiply);
            view.DivClicked += (s, e) => Calculate(model.Divide);
        }

        private void Calculate(Func<double, double, double> operation)
        {
            if (double.TryParse(view.Number1, out double n1) && double.TryParse(view.Number2, out double n2))
            {
                double result = operation(n1, n2);
                view.ShowResult(result.ToString());
            }
            else
            {
                view.ShowResult("Input Error");
            }
        }
    }

}
