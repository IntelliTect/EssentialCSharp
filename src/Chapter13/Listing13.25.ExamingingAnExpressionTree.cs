namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_25
{
    using System;
    using System.Linq.Expressions;
    using static System.Linq.Expressions.ExpressionType;

    public class Program
    {
        public static void Main()
        {
            Expression<Func<int, int, bool>> expression;
            expression = (x, y) => x > y;
            Console.WriteLine("------------- {0} -------------",
                expression);
            PrintNode(expression.Body, 0);
            Console.WriteLine();
            Console.WriteLine();
            expression = (x, y) => x * y > x + y;
            Console.WriteLine("------------- {0} -------------",
                expression);
            PrintNode(expression.Body, 0);
        }

        public static void PrintNode(Expression expression,
            int indent)
        {
            if(expression is BinaryExpression binaryExpression)
                PrintNode(binaryExpression, indent);
            else
                PrintSingle(expression, indent);
        }

        private static void PrintNode(BinaryExpression expression,
          int indent)
        {
            PrintNode(expression.Left, indent + 1);
            PrintSingle(expression, indent);
            PrintNode(expression.Right, indent + 1);
        }

        private static void PrintSingle(
                Expression expression, int indent) =>
            Console.WriteLine("{0," + indent * 5 + "}{1}",
              "", NodeToString(expression));

        private static string NodeToString(Expression expression) =>
            expression.NodeType switch
            {
                // using static ExpressionType
                Multiply => "*",
                Add => "+",
                Divide => "/",
                Subtract => "-",
                GreaterThan => ">",
                LessThan => "<",
                _ => expression.ToString() +
                    " (" + expression.NodeType.ToString() + ")",
            };
    }
}