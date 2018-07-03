using CustomerRepository.Interface;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomerRepository.ViewModel
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        ICustomerRepository repo;
        private IEnumerable<Customer> customers;

        public IEnumerable<Customer> Customers
        {
            get { return customers; }
            set 
            { 
                customers = value;
                RaisePropertyChanged("Customers");
            }
        }

        public CustomerViewModel()
        {
            repo = RepositoryFactory.GetRepository();
        }

        public void GetCustomers()
        {
            this.Customers = repo.GetCustomers();
        }

        public void ClearCustomers()
        {
            this.Customers = new List<Customer>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
