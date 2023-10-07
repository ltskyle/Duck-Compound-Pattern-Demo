using compound;

namespace compound
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck() {
            return new QuackCounter(new MallerdDuck());
        }
        public override IQuackable CreateRedHeadDuck() {
            return new QuackCounter(new ReadHeadDuck());
        }
        public override IQuackable CreateDuckCall() {
            return new QuackCounter(new DuckCall());
        }
        public override IQuackable CreateRubberDuck() {
            return new QuackCounter(new RubberDuck());
        }
    }
}
