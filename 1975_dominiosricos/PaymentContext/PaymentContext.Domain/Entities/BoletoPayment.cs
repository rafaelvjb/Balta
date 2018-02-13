using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment :Payment
    {
        public BoletoPayment(string barCode, 
                            string nossoNumero, 
                            DateTime paidDate,
                            DateTime expireDate, 
                            decimal total,
                            decimal totalPaid, 
                            Address address, 
                            Document document, 
                            string payer, 
                            Email email) 
                            : base ( paidDate,  expireDate,  total,  totalPaid,  address,  document,  payer, email)
        {
            BarCode = barCode;
            NossoNumero = nossoNumero;
        }

        public string BarCode { get; private set; }
        public string NossoNumero { get; private set; }
    }
}