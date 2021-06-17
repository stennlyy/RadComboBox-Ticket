using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxWPF
{
    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        //Adding this auto-calculated Property allows for direct display of Customer Name and Customer Id in the selection box
        public string CustomerFullInfo => $"Name: {this.Name} - Id: {this.Id}";

        public override string ToString()
        {
            return this.Id.ToString();
        }
    }
}
