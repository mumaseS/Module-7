using System;

abstract class Delivery
{
    public string City;
    public string Address;
    public int DeliveryTime;
    public string TelephoneNumber;
     
}

  class PaymentDetails 
{
    public static decimal Price;
    public static decimal Discount;
    public int CashBack;
    public int Summ;

    public static decimal DisplayPrice(decimal Price, decimal Discount)
    {
        decimal Summ = Price - (Price * Discount);
        return Summ;
    }
    

    protected void PayByCard ()
    {
        CardData(CardNumber, CVC, CardHolderName, Valid);
    }
    
    protected long CardNumber;
    protected int CVC;
    protected string CardHolderName;
    protected int Valid;
    public void CardData(long _cardnumber, int _cvc, string _cardholdername, int _valid )
    {
        CardNumber = _cardnumber;
        CVC = _cvc;
        CardHolderName = _cardholdername;
        Valid = _valid;
    }
 }

class HomeDelivery : Delivery
{
    public void _HomeDelivery() { }
      public string Address;
      public int DeliveryTime;    
    
    public void CourierCompany()
    {
        string CompanyName;
        string CourierName;
        string CourierNumber;
    }   
}     
    


class PickPointDelivery : Delivery
{
    protected void PickPointStash()
    {
        string StashAdress;
        string StashName;
        int DeliveryTime;
    }
}

class ShopDelivery : Delivery
{
    string ShopName;
}

class Order<TDelivery, TPaymentDetails> where TDelivery : Delivery where TPaymentDetails : PaymentDetails
{
    public TDelivery Delivery;

    public TPaymentDetails PaymentDetails;

    public int Number;

    public string Description;

    public void PaymentMethod()
    {
    

    }

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    public void DisplayPaymentDetails()
    {
        Console.WriteLine();
    }

   



    class Program
    {
        public void Main(string[] args)
        {

        }
    }
}