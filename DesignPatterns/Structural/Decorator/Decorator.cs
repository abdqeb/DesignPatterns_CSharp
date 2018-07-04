namespace DesignPatterns.Structural.Decorator
{
    public class A { public virtual string Text() { return "A"; } } //A
    public class B : A { public override string Text() { return base.Text() + "B"; } } //AB
    public class C : A { public override string Text() { return base.Text() + "C"; } } //AC
    public class BC : A { public override string Text() { return base.Text() + "BC"; } } //ABC
    public class CB : A { public override string Text() { return base.Text() + "CB"; } } //ACB

    //Rewrite the below into Decorator Pattern
    //A a; 
    //switch (n) 
    //{ 
    //	case 1: a = new A(); 
    //	case 2: a = new B(); 
    //	case 3: a = new C(); 
    //	case 4: a = new BC(); 
    //	case 5: a = new CB(); 
    //} 
    //a.f();

    public class Decorator
    {

    }
}
