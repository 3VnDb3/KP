using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.ViewModels
{
    public class ClientViewModel
    {
        
        public long id { get; set; }

        public string fio { get; set; }

        public string dataRozd { get; set; }
        public int numberBooks { get; set; }
        public int placeInTop { get; set; }
        public string gender { get; set; }

    }
}
