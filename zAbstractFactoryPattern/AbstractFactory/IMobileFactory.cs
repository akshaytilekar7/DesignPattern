namespace AbstractFactoryPattern.AbstractFactory;

interface IMobileFactory
{
    ISmart GetSmart();
    INormal GetNormal();
}
