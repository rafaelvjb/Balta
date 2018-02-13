using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment:Payment
    {
        public CreditCardPayment(string cardHolderName, 
                                string cardLastNumbers, 
                                string lastTransactionNumber,
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
            CardHolderName = cardHolderName;
            CardLastNumbers = cardLastNumbers;
            LastTransactionNumber = lastTransactionNumber;
        }

        //usar gateways
        public string CardHolderName { get; private set; }
        public string CardLastNumbers { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
    
}