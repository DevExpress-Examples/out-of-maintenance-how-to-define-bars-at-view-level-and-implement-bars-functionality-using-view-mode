using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace WpfApplication25 {
    public class ViewModel {
        public virtual string Text { get; set; }
        public virtual IMessageBoxService MessageBoxService { get { return null; } }
        public void ShowText() {
            MessageBoxService.ShowMessage(Text);
        }
    }
}
