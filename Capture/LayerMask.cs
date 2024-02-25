using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncron
{
    internal class LayerMask
    {
        public string MaskName;
        public static LayerMask[] Layers = new LayerMask[10];
        public LayerMask(string name) {  this.MaskName = name; }
    }
}
