using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public class Buyer : IObserver
    {
        public Buyer(string name, TextBox txtlog)
        {
            this.Name = name;
            this.Log = txtlog;
        }
        public string Name { get; set; }
        public TextBox Log { get; set; }
        public void Update(string Menu)
        {
            //throw new NotImplementedException();
            Log.AppendText(string.Format("{0}:我得到了消息菜单变化了。马上采购去{1}", this.Name, System.Environment.NewLine));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
