using System.Configuration;
using System.Data;
using System.Windows;
using PZ9_12.View;
using PZ9_12.Model;
using PZ9_12.Presenter;

namespace PZ12;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var view = new MainWindow();
        var model = new CModel();
        var presenter = new CPresenter(view, model);
        view.Show();
    }
}


