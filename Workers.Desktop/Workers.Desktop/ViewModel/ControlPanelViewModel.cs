using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers.Console.Repo;

namespace Workers.Desktop.ViewModel
{
    public partial class ControlPanelViewModel : ObservableObject
    {
        private EmployeeRepo _repo;

        [ObservableProperty]
        private string _numberOfEmployees = string.Empty;

        [ObservableProperty]
        private string _numberOfPaidEmployees = string.Empty;

        [ObservableProperty]
        private string _numberOfUnpaidEmployees = string.Empty;

        [ObservableProperty]
        private string _highestSalaryEmployee = string.Empty;

        [ObservableProperty]
        private string _lowestSalaryEmployee = string.Empty;

        [ObservableProperty]
        private string _averageSalary = string.Empty;

        public ControlPanelViewModel(EmployeeRepo repo)
        {
            _repo = repo;
            _numberOfEmployees = $"Az összes dolgozó száma: {_repo.GetNumberOfEmployees}";
            _numberOfPaidEmployees = $"Fizetést kapó dolgozók száma: {_repo.GetPaidEmployeeCount}";
            _numberOfUnpaidEmployees = $"fizetés nélküli dolgozók száma: {_repo.GetUnpaidEmployeeCount}";
            _highestSalaryEmployee = $"A legnagyobb fizetést kapó dolgozó neve: {_repo.GetHighestSalaryEmployee}";
            _lowestSalaryEmployee = $"legkisebb fizetést kapó dolgozó neve: {_repo.GetLowestSalaryEmployee}";
            _averageSalary = $"Átlagkereset: {_repo.GetAverageSalary}";

        }
    }

}
