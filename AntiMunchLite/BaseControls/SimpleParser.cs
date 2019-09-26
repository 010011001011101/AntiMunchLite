using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AntiMunchLite.BaseControls
{
  public static class SimpleParser
  {
    private static readonly Lazy<Random> Random = new Lazy<Random>(() => new Random(DateTime.Now.Millisecond));

    private static readonly (string Sign, Func<int, int, int> Operation)[] Operations =
    {
        ("*", (Func<int, int, int>) ((a, b) => a * b)),
        ("-", (Func<int, int, int>) ((a, b) => a - b)),
        ("+", (Func<int, int, int>) ((a, b) => a + b))
      };

    public static int Parse(string str, out string parseDescription)
    {
      var chain = new LinkedList<INode>();

      var signs = string.Join(null, Operations.Select(i => '\\' + i.Sign));

      var matchFirst = Regex.Match(str, $"^([^{signs}]*)");
      chain.AddLast(new ElementNode(matchFirst.Groups[1].Captures[0].Value, Random.Value));

      var match = Regex.Match(str, $"([{signs}])([^{signs}]*)");
      while (match.Success)
      {
        chain.AddLast(new OperationNode(match.Groups[1].Captures[0].Value));
        chain.AddLast(new ElementNode(match.Groups[2].Captures[0].Value, Random.Value));
        match = match.NextMatch();
      }

      foreach (var operation in Operations)
      {
        var node = chain.First;
        while (node != null)
        {
          if (node.Value is OperationNode operationNode && operationNode.Sign == operation.Sign)
          {
            ((ElementNode)node.Previous.Value).ApplyOpeartion((ElementNode)node.Next.Value, operation.Sign, operation.Operation);
            node = node.Previous;
            node.List.Remove(node.Next);
            node.List.Remove(node.Next);
          }

          node = node.Next;
        }
      }

      var result = (ElementNode)chain.First.Value;
      parseDescription = result.Description;
      return result.Value;
    }

    private interface INode
    {
    }

    private class ElementNode : INode
    {
      public int Value { get; private set; }
      public string Description { get; private set; }

      public ElementNode(string str, Random random)
      {
        try
        {
          var matchDice = Regex.Match(str, "^\\s*(\\d*)([dDhH])(\\d+)");
          if (matchDice.Success)
          {
            var countStr = matchDice.Groups[1].Captures[0].Value;
            var count = string.IsNullOrWhiteSpace(countStr)
              ? 1
              : Convert.ToInt32(countStr);
            var type = matchDice.Groups[2].Captures[0].Value.ToLower();
            var dice = Convert.ToInt32(matchDice.Groups[3].Captures[0].Value);

            var sb = new StringBuilder("(");
            for (var i = 0; i < count; ++i)
            {
              var diceThrow = _ThrowDice(type, i, dice, random);
              Value += diceThrow;

              if (i > 0) sb.Append("+");
              sb.Append(diceThrow);
            }
            sb.Append(")");
            Description = sb.ToString();
            return;
          }

          var matchSimple = Regex.Match(str, "^\\s*(\\d+)");
          if (matchSimple.Success)
          {
            Value = Convert.ToInt32(matchSimple.Groups[1].Captures[0].Value);
            Description = Value.ToString();
            return;
          }

          Description = Value.ToString();
        }
        catch (OverflowException)
        {
          Description = "[Overflow]";
        }
      }

      private int _ThrowDice(string type, int diceNum, int dice, Random random)
      {
        switch (type)
        {
          case "d":
            return _NormalDice(diceNum, dice, random);
          case "h":
            return _MaxFirstDice(diceNum, dice, random);
          default:
            throw new ArgumentOutOfRangeException(nameof(type));
        }
      }

      private static int _NormalDice(int diceNum, int dice, Random random)
      {
        return random.Next(1, dice + 1);
      }

      private static int _MaxFirstDice(int diceNum, int dice, Random random)
      {
        return diceNum == 0
          ? dice
          : random.Next(1, dice + 1);
      }

      public void ApplyOpeartion(ElementNode otherElement, string sign, Func<int, int, int> operation)
      {
        Value = operation(Value, otherElement.Value);
        Description = $"{Description} {sign} {otherElement.Description}";
      }
    }

    private class OperationNode : INode
    {
      public string Sign { get; }

      public OperationNode(string sign)
      {
        Sign = sign;
      }
    }
  }
}