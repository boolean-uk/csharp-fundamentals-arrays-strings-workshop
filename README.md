# Strings workshop

How can we reverse a string in C#?

```cs

string hw = "hello world";        
Console.WriteLine(hw.Reverse());
Console.WriteLine(new string(hw.Reverse().ToArray()));
Console.WriteLine(Microsoft.VisualBasic.Strings.StrReverse(hw));
```

See the example in this repo for an extension method solution..
