namespace AbstractFactoryPattern.AbstractFactory;

interface IMobileFactory
{
    ISmart GetAndroid();
    INormal GetIPhone();
}
