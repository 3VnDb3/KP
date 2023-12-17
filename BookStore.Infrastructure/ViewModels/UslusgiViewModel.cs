using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure.ViewModels
{
    public class UslusgiViewModel
    {
        public long id {  get; set; }
        public string name { get; set; }
        public int numberBooks { get; set; }
        public int placeInTop { get; set; }
    }
}
