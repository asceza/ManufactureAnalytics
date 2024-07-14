using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureAnalytics
{
    // Класс Изделие
    class Product
    {
        public string Title { get; set; }
        public string NumberProduct { get; set; }
        public uint NumberTrain { get; set; }
        public float LeadTimeInHours { get; set; }
        public byte Status { get; set; }

        /// <summary>
        /// аргумент <b>Status:</b><br/>
        /// 0 - отгружены комплектующие<br/>
        /// 1 - сборка<br/>
        /// 2 - передано на ПСИ<br/>
        /// 3 - передано в ОТК<br/>
        /// 4 - передано в упаковку<br/>
        /// 5 - отгружено<br/>
        /// </summary>
        public Product(string title,
                       string numberProduct,
                       uint numberTrain,
                       float leadTimeInHours = 0,
                       byte status = 0)
        {
            Title = title;
            NumberProduct = numberProduct;
            NumberTrain = numberTrain;
            LeadTimeInHours = leadTimeInHours;


            Status = status;
        }
    }
}
