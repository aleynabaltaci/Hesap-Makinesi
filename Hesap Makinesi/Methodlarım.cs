using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public class Methodlarım
    {
        public static void fibonacciM(int adım)
        {
            List<int> fibo = new List<int>() { 0,1};
            for (int i = 0; i <= adım; i++)
            {
                fibo.Add(fibo[i] + fibo[i + 1]);
            }
            foreach (int sayılar in fibo)
            {
                MessageBox.Show(sayılar.ToString());
            }
        }
     
    }
}
