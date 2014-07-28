using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NXclasslib
{
    public class Class1
    {
        public static int Main(string[] Args)
        {
            try
            {
                MessageBox.Show("HOLLE,MY WORLD!");
                return 0;
            }
            catch (Exception)
            {
                return 1;
            }

        }
    }
}
