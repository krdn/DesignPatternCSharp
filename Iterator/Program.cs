// See https://aka.ms/new-console-template for more information
using Iterator;
using Array = Iterator.Array;


Item[] items =
{
    new Item("CPU", 1000),
    new Item("RAM", 500),
    new Item("HDD", 300),
    new Item("SSD", 400)
};

var array = new Array(items);
var iterator = array.Iterator();

while (iterator.Next())
{
    Console.WriteLine(iterator.Current());
}

