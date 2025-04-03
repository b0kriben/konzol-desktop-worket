using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers.Console.Repo;

namespace Workers.Desktop.ViewModel
{
    public class MainViewModel
    {
        private EmployeeRepo _repo = new EmployeeRepo();

        public ControlPanelViewModel ControlPanelViewModel { get; set; }
        public EmployeeManagmentViewModel EmployeeManagmentViewModel { get; set; }

        public MainViewModel()
        {
            ControlPanelViewModel = new ControlPanelViewModel(_repo);
            EmployeeManagmentViewModel = new EmployeeManagmentViewModel(_repo);
        }
    }
}
