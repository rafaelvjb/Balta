using System;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        public Payment( DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, Document document, string payer, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Address = address;
            Document = document;
            Payer = payer;
            Email = email;

            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(0, Total, "Payment.Total", "O total n�o pode ser zero")
               );
        }

        public String Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public Decimal Total { get; private set; }
        public Decimal TotalPaid { get; private set; }
        public Address Address { get; private set; }
        public Document Document { get; private set; }
        public string Payer { get; private set; }
        public Email Email { get; private set; }
        
    }
    
}