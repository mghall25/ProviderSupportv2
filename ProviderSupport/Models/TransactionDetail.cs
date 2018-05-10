using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProviderSupport.Models
{
    public class TransactionDetail
    {
        public List<ServiceType> ServiceTypeList { get; set; }
        public string SelectedAnswer { set; get; }
    }
}