using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PZ9_12.View;
using PZ9_12.Model;
using PZ9_12.Presenter;

namespace PZ12;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, IView
{
    public event EventHandler AddClicked;
    public event EventHandler SubClicked;
    public event EventHandler MulClicked;
    public event EventHandler DivClicked;

    public string Number1 => txtNum1.Text;
    public string Number2 => txtNum2.Text;

    public MainWindow()
    {
        InitializeComponent();
        btnAdd.Click += (s, e) => AddClicked?.Invoke(this, EventArgs.Empty);
        btnSub.Click += (s, e) => SubClicked?.Invoke(this, EventArgs.Empty);
        btnMul.Click += (s, e) => MulClicked?.Invoke(this, EventArgs.Empty);
        btnDiv.Click += (s, e) => DivClicked?.Invoke(this, EventArgs.Empty);
    }

    public void ShowResult(string result)
    {
        txtResult.Text = "Результат: " + result;
    }
}