namespace FactoryMethodPattern;

public enum TaxOptions
{
    PrePaid,
    DutyFree,
    PayOnArrival
}

public enum ShippingType
{
    Standard,
    Express,
    NextDay
}

public enum ShippingStatus
{
    WaitingForPayment,
    ReadyForShipment,
    Shipped
}
