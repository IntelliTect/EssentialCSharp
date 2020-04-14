using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_31
{
    public class Publisher
    {
        static public object? InvokeAll<TDelegate>(
            object?[]? args, params TDelegate[] delegates)
            // Constraint of type Action/Func not allowed
            where TDelegate : System.MulticastDelegate
        {
          switch (Delegate.Combine(delegates))
          {
              case Action action:
                  action();
                  return null;
              case TDelegate result:
                  return result.DynamicInvoke(args);
              default:
                  return null;
          };
        }

        static public void InvokeAll(params Action?[] actions)
        {
            Action? result = (Action?)Delegate.Combine(actions);
            result?.Invoke();
        }
    }
}
