using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CollateralModel
    {
        #region Fields

        private long? collateralId;
        private string collateralStatus;
        private string region;
        private DateTime? collateralDate;
        private DateTime? deliveryDay;
        private DateTime? recordTime;
        private DateTime? checkCollateralDate;
        private double? availableCashCollateral;
        private double? availableTotalCollateral;
        private double? requiredCashCollateral;
        private double? requiredTotalCollateral;
        private long? organizationCode;
        private string organizationName;
        private bool? participationAggrement;

        #endregion

        #region Properties

        /// <summary>
        /// ID
        /// </summary>
        public long? CollateralId
        {
            get
            {
                return collateralId;
            }

            set
            {
                this.collateralId = value;
            }
        }

        /// <summary>
        /// Teminat Durumu
        /// </summary>
        public string CollateralStatus
        {
            get
            {
                return collateralStatus;
            }

            set
            {
                this.collateralStatus = value;
            }
        }

        /// <summary>
        /// Bölge
        /// </summary>
        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                this.region = value;
            }
        }

        /// <summary>
        /// Teminatın kontrolünün yapılacağı gün
        /// </summary>
        public DateTime? CollateralDate
        {
            get
            {
                return collateralDate;
            }

            set
            {
                this.collateralDate = value;
            }
        }

        /// <summary>
        /// Teminatın kullanıcağı teslim günü
        /// </summary>
        public DateTime? DeliveryDay
        {
            get
            {
                return deliveryDay;
            }

            set
            {
                this.deliveryDay = value;
            }
        }

        /// <summary>
        /// Takas Bank' tan teminatın çekilme zamanı
        /// </summary>
        public DateTime? RecordTime
        {
            get
            {
                return recordTime;
            }

            set
            {
                this.recordTime = value;
            }
        }

        /// <summary>
        /// Teminatın kontrol edildiği zaman
        /// </summary>
        public DateTime? CheckCollateralDate
        {
            get
            {
                return checkCollateralDate;
            }

            set
            {
                this.checkCollateralDate = value;
            }
        }

        /// <summary>
        /// Mevcut Nakit Teminat
        /// </summary>
        public double? AvailableCashCollateral
        {
            get
            {
                return availableCashCollateral;
            }

            set
            {
                this.availableCashCollateral = value;
            }
        }

        /// <summary>
        /// Mevcut Toplam Teminat
        /// </summary>
        public double? AvailableTotalCollateral
        {
            get
            {
                return availableTotalCollateral;
            }

            set
            {
                this.availableTotalCollateral = value;
            }
        }

        /// <summary>
        /// Gerekli Nakit Teminat
        /// </summary>
        public double? RequiredCashCollateral
        {
            get
            {
                return requiredCashCollateral;
            }

            set
            {
                this.requiredCashCollateral = value;
            }
        }

        /// <summary>
        /// Gerekli Toplam Teminat
        /// </summary>
        public double? RequiredTotalCollateral
        {
            get
            {
                return requiredTotalCollateral;
            }

            set
            {
                this.requiredTotalCollateral = value;
            }
        }

        /// <summary>
        /// Organizasyon Kodu
        /// </summary>
        public long? OrganizationCode
        {
            get
            {
                return organizationCode;
            }

            set
            {
                this.organizationCode = value;
            }
        }

        /// <summary>
        /// Organizasyon Kısa Adı
        /// </summary>
        public string OrganizationName
        {
            get
            {
                return organizationName;
            }

            set
            {
                this.organizationName = value;
            }
        }

        /// <summary>
        /// Katılım Anlaşması durumu
        /// </summary>
        public bool? ParticipationAggrement
        {
            get
            {
                return participationAggrement;
            }

            set
            {
                this.participationAggrement = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public CollateralModel()
        {

        }

        #endregion
    }
}
