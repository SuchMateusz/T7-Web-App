using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMVC.Domain.Model;

namespace WebAppMVC.Application.ViewModel.Customer
{
    public class CustomerDetailsVM
    {
        public int Id { get; set; }
        public string Login { get; set; }

        public string NIP { get; set; }

        public string PhoneNubmer { get; set; }

        public string AddressEmail { get; set; }

        public List<CustomerContactInformactionForListVm> CustomerContactInformaction { get; set; }

        public List<AddressForListVM> AddressDetails { get; set; }

    }
}
