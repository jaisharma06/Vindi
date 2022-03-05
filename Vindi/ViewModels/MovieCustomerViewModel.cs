using System.Collections.Generic;
using Vindi.Models;

namespace Vindi.ViewModels
{
    public class MovieCustomerViewModel
    {
        public Movie movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}
