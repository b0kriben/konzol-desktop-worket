using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers.Console.Models;
using Workers.Console.Repo;
using Workers.Desktop.View;

namespace Workers.Desktop.ViewModel
{
    public partial class EmployeeManagmentViewModel : ObservableObject
    {
        private readonly EmployeeRepo _repo;

        [ObservableProperty]
        private ObservableCollection<Employee> _work;

        public EmployeeManagmentViewModel(EmployeeRepo repo)
        {
            _repo = repo;
            _work = new ObservableCollection<Employee>(_repo.GetAll());
        }
    }
}
