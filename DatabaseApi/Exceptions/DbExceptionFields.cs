using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Exceptions
{
    public static class DbExceptionFields
    {
        public const string DuplicateCategoryName = "DuplicateCategoryName";
        public const string InvalidCategoryId = "InvalidCategoryId";
        public const string InvalidCategoryName = "InvalidCategoryName";
        public const string MissingParentCategoryId = "MissingParentCategoryId";
        public const string InvalidProductId = "InvalidProductId";
        public const string InvalidProductCode = "InvalidProductCode";
        public const string InvalidProductNameLength = "InvalidProductNameLength";
        public const string InvalidProductDescriptionLength = "InvalidProductDescriptionLength";
        public const string InvalidQuantity = "InvalidQuantity";
        public const string InvalidPrice = "InvalidPrice";
        public const string InvalidProductCategory = "InvalidProductCategory";
        public const string InvoiceItemNotFound = "InvoiceItemNotFound";
        public const string WarehouseIdNotFound = "WarehouseIdNotFound";
        public const string BankNotFound = "BankNotFound";
        public const string CustomerNotFound = "CustomerNotFound";
        public const string InvalidInvoiceItemQuantity = "InvalidInvoiceItemQuantity";
        public const string InvalidInvoiceItemPrice = "InvalidInvoiceItemPrice";
        public const string InvalidTotalInvoicePrice = "InvalidTotalInvoicePrice";
    }
}
