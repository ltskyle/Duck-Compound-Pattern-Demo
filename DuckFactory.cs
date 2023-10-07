using compound;

namespace compound
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck() {
            return new MallerdDuck();
        }
        public override IQuackable CreateRedHeadDuck() {
            return new ReadHeadDuck();
        }
        public override IQuackable CreateDuckCall() {
            return new DuckCall();
        }
        public override IQuackable CreateRubberDuck() {
            return new RubberDuck();
        }
    }
}
