using BusinessObject;
using EmployeesUI.ServiceReference1;
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

namespace EmployeesUI
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public string valor= "";
        public Page2()
        {
            InitializeComponent();
            GetEmployees();
        }
        public List<EmployeeObject> GetEmployees()
        {
            Service1Client servicio = new Service1Client();
            List<EmployeeObject> lista = servicio.GetEmployees();
            dataGrid.ItemsSource= lista;
            return lista;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.StaticMainFrame.Content = new Page1(valor);
        }
        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            string Id = (string)((Button)sender).CommandParameter;
           
            Page1 pag = new Page1(Id);
            pag.Num_Id = Id;
            MainWindow.StaticMainFrame.Content = pag;

        }
    }
}
