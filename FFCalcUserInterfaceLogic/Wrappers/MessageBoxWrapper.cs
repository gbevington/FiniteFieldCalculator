using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFCalcUserInterfaceLogic.Wrappers
{
    public interface IMessageBoxWrapper
    {
        void Show(string message);
    }

    public class MessageBoxWrapper : IMessageBoxWrapper
    {
        public void Show(string message)
        {
            MessageBox.Show(message);
        }
    }
}
