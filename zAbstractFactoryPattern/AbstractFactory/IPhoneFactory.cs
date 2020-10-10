namespace zAbstractFactoryPattern.AbstractFactory
{
    interface IPhoneFactory
    {
        ISmart GetSmart();
        INormal GetNormal();
    }
}
