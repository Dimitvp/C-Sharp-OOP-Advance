using System;

public class StartUp
{
    static void Main()
    {
        Spy spy = new Spy();
        //string result = spy.AnalyzeAcessModifiers("Hacker");
        //string result = spy.RevealPrivateMethods("Hacker");
        string result = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(result);
    }
}