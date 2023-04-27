// See https://aka.ms/new-console-template for more information

using _02.Strategy;

Console.WriteLine("Hello, World!");

var title = "Design Pattern";

var content = new List<string>
{
    "Iterator",
    "Strategy",
    "Observer",
    "Decorator",
    "Factory Method",
    "Abstract Factory",
    "Singleton",
    "Command",
    "Adapter",
    "Facade",
    "Template Method",
    "Composite",
    "State",
    "Proxy",
    "Compound",
    "Bridge",
    "Builder",
    "Interpreter",
    "Mediator",
    "Memento",
    "Flyweight",
    "Prototype", 
    "Visitor"

};

var footer = "Design Pattern 끝";

var article = new Article(title, content, footer);      

