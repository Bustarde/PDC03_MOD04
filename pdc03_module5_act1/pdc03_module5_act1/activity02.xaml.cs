using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace pdc03_module5_act1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity02 : ContentPage

    {

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }

        public activity02()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "New President" });
            employees.Add(new Employee { DisplayName = "John Doe", Position = "Vice President" });
            employees.Add(new Employee { DisplayName = "Peter Cruz", Position = "Director" });
            employees.Add(new Employee { DisplayName = "Maria Dela Cruz", Position = "Superviser" });
        }

        private void Add_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }

        private void Edit_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }

        private void Delete_item(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (menuItem != null)
            {

            }
        }
    }
}