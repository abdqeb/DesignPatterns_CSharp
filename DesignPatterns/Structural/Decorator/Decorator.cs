namespace DesignPatterns.Structural.Decorator
{
    public interface IText
    {
        string Text();
    }
    //Base Class
    public class A : IText
    {
        public A() { }
        public virtual string Text() { return "A"; }
    }
    public abstract class ADecorator : IText
    {
        protected IText _text;
        public ADecorator(IText newText) { _text = newText; }
        public abstract string Text();
    }
    // B Decoration
    public class B : ADecorator, IText
    {
        public B(IText newText) : base(newText) {}
        public override string Text() { return _text.Text() + "B"; }
    } 
    // C Decoration
    public class C : ADecorator, IText
    {
        public C(IText newText) : base(newText) { }
        public override string Text() { return _text.Text() + "C"; }
    }
}
