using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WinFormsAppNamedPipeServerStream
{
    public class Automation
    {
        public void Message(string text)
        {
            MessageBox.Show(text);
        }
    }
}
