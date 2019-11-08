using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Quan_ly_bong_da
{
    class Image
    {
       public static System.Drawing.Image image(string path1)
        {
            System.Drawing.Image tmp;
            using (System.Drawing.Image to = System.Drawing.Image.FromFile(Bien.path + path1))
            {
                tmp = new Bitmap(to);
            }
            return tmp;
        }
    }
}
