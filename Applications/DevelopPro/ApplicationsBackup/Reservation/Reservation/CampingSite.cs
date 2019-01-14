using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    public class CampingSite
    {
        private int campingId;
        private string campingType;
        private string startDate;
        private string endDate;
        private string status;
        private int price;

        public int CampingId
        {
            get { return campingId; }
            set { campingId = value; }
        }

        public string CampingType
        {
            get { return campingType; }
            set { campingType = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public CampingSite(int campingId, string campingType, string status, int price)
        {
            this.campingId = campingId;
            this.campingType = campingType;
            this.status = status;
            this.price = price;
        }

        public CampingSite(int campingId, string campingType, string startDate, string endDate, string status)
        {
            this.campingId = campingId;
            this.campingType = campingType;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
        }
    }
}
