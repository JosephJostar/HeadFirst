using System;
using static System.Console;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)    //策略模式
        {
            MallardDuck mallard = new MallardDuck();  // 子类实例 使用已实例化的接口方法
            /*mallard.performQuack();
            mallard.performFly();*/

            mallard.quackBe.Quack();
            mallard.flyBe.Fly();
            mallard.display();

            ModelDuck model = new ModelDuck();
            model.quackBe.Quack();
            model.flyBe.Fly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.flyBe.Fly();
            model.display();

            duckcall AnDuckCall = new duckcall();
            AnDuckCall.vc.voice();
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBe = new Quackit();       //子类将基类接口根据需要使用的 接口实现类 实例化
            flyBe = new FlyWithWings();
        }

        public void display()
        {
            WriteLine("I'm a real Mallard duck!");
        }
    }

    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            flyBe = new FlyNoWay();
            quackBe = new Quackit();
        }

        public void display()
        {
            WriteLine("I'm a model duck!");
        }
    }

    public abstract class Duck
    {
        public QuackBehavior quackBe;    //基类声明接口 
        public FlyBehavior flyBe;

        /*       public void performQuack()     
                {
                    quackBe.Quack();
                }

                public void performFly()
                {
                    flyBe.Fly();
                }*/
        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBe = fb;
        }
        public void SetQuackBehavior(QuackBehavior qb)
        {
            quackBe = qb;
        }
    }

    public interface FlyBehavior
    {
        public void Fly();
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            WriteLine("I'm flying with a rocket!");
        }
    }

    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            WriteLine("I can't fly");
        }
    }



    public interface QuackBehavior
    {
        public void Quack();
    }

    public class Quackit : QuackBehavior
    {
        public void Quack()
        {
            WriteLine("Quackit");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            WriteLine("<<Silence>>");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            WriteLine("Squeak");
        }
    }
}
