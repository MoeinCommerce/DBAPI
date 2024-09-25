using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public partial class Person
    {
        public int Code { get; set; }                      // Code of the person
        public string Name { get; set; }                   // Full Name
        public string CEO { get; set; }                    // CEO or Managing Director (ModirAmel)
        public string Position { get; set; }               // Position (Semat)
        public string Address { get; set; }                // Address
        public string Company { get; set; }                // Company name
        public string FirstName { get; set; }              // First Name (Fname)
        public string LastName { get; set; }               // Last Name (LName)
        public string EconomicCode { get; set; }           // Economic Code (Eghtesadi)
        public string PostalCode { get; set; }             // Postal Code (Posti)
        public string RegistrationNo { get; set; }         // Company Registration Number (Sabt)
        public string IdentityCardNo { get; set; }         // Identity Card Number (CardNo)
        public string CompanyAddress { get; set; }         // Company Address
        public string Email { get; set; }                  // Email Address
        public string BankAccountNo { get; set; }          // Bank Account Number (HesabNo)
        public string Website { get; set; }                // Website (Site)
        public string Education { get; set; }              // Education (Tahsilat)
        public string DateOfBirth { get; set; }            // Date of Birth (Tavalod)
        public string Picture { get; set; }                // Profile Picture URL (Pic)
        public string NationalID { get; set; }             // National ID (Melli)
        public Nullable<float> VisitorPercentage { get; set; }  // Percentage for visitors (VisitorPerc)
        public Nullable<decimal> InitialBalance { get; set; }   // Initial balance (MablaghAvalDore)
        public Nullable<int> GroupID { get; set; }         // Group ID
        public string AdditionalInfo { get; set; }         // Additional Information (Info)
        public string State { get; set; }                  // State or Province
        public string City { get; set; }                   // City
        public string JobTitle { get; set; }               // Job Title (Job)
        public Nullable<decimal> CashCredit { get; set; }  // Cash Credit (EtebarNaghd)
        public Nullable<int> PurchasePriceLevel { get; set; } // Purchase Price Level (BuyPriceLevel)
        public Nullable<int> SalesPriceLevel { get; set; }    // Sales Price Level (SellPriceLevel)
        public Nullable<decimal> ChequeCredit { get; set; }   // Cheque Credit (EtebarCheque)
        public string TitlePrefix { get; set; }            // Name prefix (Prefix, like Mr., Mrs.)
        public bool IsActive { get; set; }                 // Active Status
        public string StartDate { get; set; }              // Start Date (StartDate)
        public int ID { get; set; }                        // Unique ID
        public Nullable<bool> IsVisitor { get; set; }      // Whether they are a visitor (VisitorType)
        public bool IsCourier { get; set; }                // Whether they are a courier (Peyk)
        public short CourierType { get; set; }             // Courier Type (PeykType)
        public Nullable<decimal> DeliveryPrice { get; set; } // Delivery or Carry Price (CarryPrice)
        public string ShiftStart { get; set; }             // Shift Start Time (ShiftFrom)
        public string ShiftEnd { get; set; }               // Shift End Time (ShiftTo)
        public string VehicleType { get; set; }            // Type of Vehicle (VehicleType)
        public string VehiclePlate { get; set; }           // Vehicle Plate Number (VehiclePelak)
        public string VehicleColor { get; set; }           // Vehicle Color (VehicleColor)
        public string PhoneNumber { get; set; }            // Telephone number (Tel)
        public Nullable<bool> Visitor { get; set; }        // Visitor Status (Visitor)
        public Nullable<bool> VisitorDebt { get; set; }    // Visitor Debt (VisitorBed)
    }
}
