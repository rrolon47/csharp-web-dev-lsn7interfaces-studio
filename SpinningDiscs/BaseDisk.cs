using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    class abstract BaseDisk
    {
        public string Name { get; set; }
        public string Capacity { get; set; }
        public List<string> Content { get; set; }
        public string DiskType { get; set; }



    }
}
