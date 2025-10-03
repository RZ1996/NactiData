using NactiData;

Data data = new Data();
data.loadData();
data.checkOperations();
Console.WriteLine();
Console.WriteLine(data.sum());
Console.WriteLine(data.multiple());
Console.WriteLine(data.sumAndDiv());
