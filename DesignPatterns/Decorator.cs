public class A { public virtual string f() { return "A"; } }
//public class B : A { f(){ super.f(); print(“B”); } }
public class B : A { public override string f() { return base.f() + "B"; } }
//public class C : A { f(){ super.f(); print(“C”); } }
public class C : A { public override string f() { return base.f() + "C"; } }
//public class BC : A { f(){ super.f(); print(“B”); print(“C”); } }
public class BC : A { public override string f() { return base.f() + "BC"; } }
//public class CB : A { f(){ super.f(); print(“C”); print(“B”); } }
public class CB : A { public override string f() { return base.f() + "CB"; } }

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

namespace DesignPatterns
{
    public class Decorator
    {

    }
}
