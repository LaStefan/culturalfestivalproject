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
        private bool status;

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

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public CampingSite(int campingId, string campingType, bool status)
        {
            this.campingId = campingId;
            this.campingType = campingType;
            this.status = status;
        }

        public CampingSite(int campingId, string campingType, string startDate, string endDate, bool status)
        {
            this.campingId = campingId;
            this.campingType = campingType;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
        }
    }
}
