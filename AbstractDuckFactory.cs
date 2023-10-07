using compound;

public abstract class AbstractDuckFactory
{
    public abstract IQuackable CreateMallardDuck();
    public abstract IQuackable CreateRedHeadDuck();
    public abstract IQuackable CreateDuckCall();
    public abstract IQuackable CreateRubberDuck();
}