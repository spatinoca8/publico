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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public string Num_Id = "";

        public Page1(string Num_Id)
        {
            InitializeComponent();
            if (Num_Id != "")
            {
                Service1Client servicio = new Service1Client();
                EmployeeObject obj = new EmployeeObject();
                obj = servicio.GetEmployee(Num_Id);
                txtTipIdentificacion.Text = obj.Tip_Id;
                txtNumIdentificacion.Text = obj.Num_Id;
                txtNombre.Text = obj.First_Name;
                txtSegundoNombre.Text = obj.Second_Name;
                txtPrimerApellido.Text = obj.Last_Name;
                txtSegundoNombre.Text = obj.Middle_Name;
                txtDireccion.Text = obj.Addres;
                txtCelular.Text = obj.Cellphone;
                txtEmail.Text = obj.Email;
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var employee = new EmployeeObject();
            employee.Tip_Id = txtTipIdentificacion.Text;
            employee.Num_Id = txtNumIdentificacion.Text;
            employee.First_Name = txtNombre.Text;
            employee.Second_Name = txtPrimerApellido.Text;
            employee.Last_Name = txtSegundoNombre.Text;
            employee.Middle_Name = txtSegundoApellido.Text;
            employee.Addres = txtDireccion.Text;
            employee.Cellphone = txtCelular.Text;
            employee.Email = txtEmail.Text;
            Service1Client servicio = new Service1Client();
            servicio.SaveEmployees(employee);
          
        }
    }
}
