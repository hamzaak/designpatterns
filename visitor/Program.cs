using System;
using System.Text;

namespace visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // emulate 1+2+3
            var e = new Addition(
                new Addition(
                    new Literal(1),
                    new Literal(2)
                ),
                new Literal(3)
            );
            var sb = new StringBuilder();
            var expressionPrinter = new ExpressionPrinter(sb);
            e.Accept(expressionPrinter);
            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }

    // Visitor
    interface IExpressionVisitor
    {
        void Visit(Literal literal);
        void Visit(Addition addition);
    }

    // Element
    interface IExpression
    {
        void Accept(IExpressionVisitor visitor);
    }

    // Concrete Element
    class Literal : IExpression
    {
        internal double Value { get; set; }

        public Literal(double value)
        {
            this.Value = value;
        }
        public void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // Concrete Element
    class Addition : IExpression
    {
        internal IExpression Left { get; set; }
        internal IExpression Right { get; set; }

        public Addition(IExpression left, IExpression right)
        {
            this.Left = left;
            this.Right = right;
        }

        public void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // Concrete Visitor
    class ExpressionPrinter : IExpressionVisitor
    {
        StringBuilder sb;

        public ExpressionPrinter(StringBuilder sb)
        {
            this.sb = sb;
        }

        public void Visit(Literal literal)
        {
            sb.Append(literal.Value);
        }

        public void Visit(Addition addition)
        {
            sb.Append("(");
            addition.Left.Accept(this);
            sb.Append("+");
            addition.Right.Accept(this);
            sb.Append(")");
        }
    }
}
