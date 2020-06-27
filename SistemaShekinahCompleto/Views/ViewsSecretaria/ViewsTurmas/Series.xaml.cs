using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SistemaShekinahCompleto.Entidades;
namespace SistemaShekinahCompleto.Views.ViewsSecretaria.ViewsTurmas
{
    /// <summary>
    /// Interaction logic for Series.xaml
    /// </summary>
    public partial class Series : UserControl
    {
        TodasAsSeries listaDeSeries;
        
        public Series()
        {
            listaDeSeries = new TodasAsSeries();
            
            
            InitializeComponent();
            LsBx.ItemsSource = listaDeSeries;
            LsBx.DataContext = "AnoEnt";
           
        }

    }
}
