using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GateOperationModel
    {
        /*
          "gateId": 1000044520,
          "name": "Teklif Bildirim",
          "start": "0001",
          "end": "1130",
          "duration": 5,
          "dependedGateId": null,
          "effectiveDate": "2016-04-15T00:00:00.000+0300",
          "gate": "OFFER_DECLARATION",
          "gateStatus": "CLOSE",
          "version": 1
         */

        #region Fields

        private long gateId;
        private string name;
        private string start;
        private string end;
        private int duration;
        private long? dependedGateId;
        private DateTime? effectiveDate;
        private string gate;
        private string gateStatus;
        private int version;

        public long GateId
        {
            get
            {
                return gateId;
            }

            set
            {
                this.gateId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }

        public string Start
        {
            get
            {
                return start;
            }

            set
            {
                this.start = value;
            }
        }

        public string End
        {
            get
            {
                return end;
            }

            set
            {
                this.end = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                this.duration = value;
            }
        }

        public long? DependedGateId
        {
            get
            {
                return dependedGateId;
            }

            set
            {
                this.dependedGateId = value;
            }
        }

        public DateTime? EffectiveDate
        {
            get
            {
                return effectiveDate;
            }

            set
            {
                this.effectiveDate = value;
            }
        }

        public string Gate
        {
            get
            {
                return gate;
            }

            set
            {
                this.gate = value;
            }
        }

        public string GateStatus
        {
            get
            {
                return gateStatus;
            }

            set
            {
                this.gateStatus = value;
            }
        }

        public int Version
        {
            get
            {
                return version;
            }

            set
            {
                this.version = value;
            }
        }

        #endregion

        #region Constructors

        public GateOperationModel()
        {

        }

        #endregion
    }
}
