using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class Invoice
    {
        public int InvoiceNumber { get; set; } // FactorNo -> InvoiceNumber
        public DateTime InvoiceDate { get; set; } // Date -> InvoiceDate (changed to DateTime)
        public short InvoiceType { get; set; } // Type -> InvoiceType
        public int? PersonID { get; set; } // IDShakhs -> PersonID
        public int? InvoiceCode { get; set; } // CodeFactor -> InvoiceCode
        public decimal? TotalAmount { get; set; } // JamKol -> TotalAmount
        public decimal? GMEAmount { get; set; } // GmeFactor -> GMEAmount (Assumed context)
        public bool? IsCash { get; set; } // Nagd -> IsCash
        public bool? IsCredit { get; set; } // Naseh -> IsCredit
        public bool? IsCheck { get; set; } // Chek -> IsCheck
        public decimal? CashAmount { get; set; } // Nagd2 -> CashAmount
        public decimal? CreditAmount { get; set; } // Naseh2 -> CreditAmount
        public decimal? CheckAmount { get; set; } // Chek2 -> CheckAmount
        public int? DocumentNumber { get; set; } // SanadNo -> DocumentNumber
        public string Info { get; set; } // info -> Info
        public int WarehouseID { get; set; } // Anbar -> WarehouseID
        public decimal? InvoiceBalance { get; set; } // MandeFactor -> InvoiceBalance
        public bool? IsConfirmed { get; set; } // Confirmed -> IsConfirmed
        public int? ReceiptNumber { get; set; } // FishNo -> ReceiptNumber (Assumed context)
        public DateTime InvoiceTime { get; set; } // Time -> InvoiceTime (changed to DateTime)
        public decimal? Tax { get; set; } // Maliat -> Tax
        public int? VisitorID { get; set; } // IDVisitor -> VisitorID
        public decimal? VisitorPrice { get; set; }
        public float? VisitorPercentage { get; set; } // VisitorPerc -> VisitorPercentage
        public int? TableNumber { get; set; } // MizNo -> TableNumber (Assumed context)
        public int? PersonCount { get; set; }
        public int InvoiceID { get; set; } // ID -> InvoiceID
        public decimal? Discount { get; set; } // Takhfif -> Discount
        public float? DiscountPercentage { get; set; } // TakhfifPerc -> DiscountPercentage
        public decimal CarryPrice { get; set; }
        public short CarryType { get; set; }
        public int? DriverID { get; set; }
        public string MiddleMan { get; set; }
        public int PaymentValue { get; set; }
        public short PaymentType { get; set; }
        public DateTime PaymentDate { get; set; } // PaymentDate -> PaymentDate (changed to DateTime)
        public DateTime DeliverDate { get; set; } // DeliverDate -> DeliverDate (changed to DateTime)
        public bool IsTemporary { get; set; } // Tmp -> IsTemporary
        public bool IsConverted { get; set; } // Converted -> IsConverted
        public int? ReturnID { get; set; }
        public decimal? ItemDiscount { get; set; } // TakhfifItem -> ItemDiscount
        public string DriverName { get; set; }
        public short? CarryPaymentType { get; set; } // CarryPayType -> CarryPaymentType
        public int? CarryPaymentID { get; set; } // CarryPayID -> CarryPaymentID
        public string CarrierInfo { get; set; } // CarryInfo -> CarrierInfo
        public string CarrierVehicle { get; set; } // CarryVehicle -> CarrierVehicle
        public string CarrierLicensePlate { get; set; } // CarryPelak -> CarrierLicensePlate
        public string CarrierColor { get; set; } // CarryColor -> CarrierColor
        public string CarrierPhone { get; set; } // CarryTel -> CarrierPhone
        public string Telephone { get; set; } // Tel -> Telephone
        public string Address { get; set; }
        public decimal? Service { get; set; }
        public float? TaxPercentage { get; set; } // MaliatPerc -> TaxPercentage
        public float? ServicePercentage { get; set; } // ServicePerc -> ServicePercentage
        public decimal? ServicePrice { get; set; }
        public short? DriverCalculationType { get; set; } // DriverCalcType -> DriverCalculationType
        public decimal? DriverCalculationPrice { get; set; } // DriverCalcPrice -> DriverCalculationPrice
        public decimal? RoundPrice { get; set; }
        public int? UserID { get; set; }
        public int? RepairID { get; set; } // IDTamir -> RepairID
        public int? TableID { get; set; } // MizID -> TableID
        public bool? IsInvalid { get; set; } // Invalid -> IsInvalid
        public short? InOutType { get; set; } // InOut -> InOutType
        public int? ProjectID { get; set; }
        public int? ExpenseID { get; set; } // HazineID -> ExpenseID
        public string Place { get; set; }
        public DateTime SendTime { get; set; } // SendTime -> SendTime (changed to DateTime)
        public DateTime InsertDate { get; set; } // InsertDate -> InsertDate (changed to DateTime)
        public DateTime InsertTime { get; set; } // InsertTime -> InsertTime (changed to DateTime)
    }

}
