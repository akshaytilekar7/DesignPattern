namespace AbstractFactoryDemo
{
    interface IPhoneFactory
    {
        ISmart GetSmart();
        INormal GetNormal();
    }
}
