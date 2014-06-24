using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muse
{
    public class mUtilities
    {
        public mUtilities()
        {

        }
        public static void Validate(string[] txt)
        {
            for (int i = 0; i < txt[i].Length; i++)
            {
                if (txt[i] == "")
                {
                    MessageBox.Show("Harap semua data diisi dengan benar");
                }
            }
        }
    }
}
