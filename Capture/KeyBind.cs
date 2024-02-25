using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syncron
{
    internal class KeyBind
    {
        public string ActionName;
        public Keys KeyValue;
        public KeyBind(string actionName, Keys keyValue) 
        { 
            ActionName = actionName;
            KeyValue = keyValue;
        }
    }
}
