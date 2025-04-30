using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloom.DesignTime
{
    public class Hammer
    {
        public string Name { get; set; } = "Default Hammer";
        public int Size { get; set; } = 10;

        public ObservableCollection<Nail> Nails { get; set; } = [];

    }

    public class Nail
    {
        public string Material { get; set; } = "Steel";
        public int Length { get; set; } = 5;
    }
}
