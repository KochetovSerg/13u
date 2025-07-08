using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3U
{
    public class Trade
    {
       
        
            #region Fields //===========================
            public int Sec = 0;
            /// <summary>
            /// цена сделки
            /// </summary>
            public decimal Price = 0;
            // public decimal Volume  = 0;
            public string SecCode = "";
            public string ClassCode = "";
            public DateTime DateTime = DateTime.Now;
            /// <summary>
            /// обьем сделки
            /// </summary>
            public decimal Volume
            {
                get
                {
                    return _volume;
                }
                set
                {
                    _volume = value;
                }
            }
            decimal _volume = 0;
            #endregion //==============================
        
    }
}
