var anonymousObject1 = new { Name = "AnonymousObject1" };
var anonymousObject2 = new { Name = "AnonymousObject2" };
Console.WriteLine(anonymousObject1.GetType());
Console.WriteLine(anonymousObject1.GetType() == anonymousObject2.GetType());

dynamic dynamicObject1 = 10;
Console.WriteLine(dynamicObject1.GetType());
dynamic dynamicObject2 = anonymousObject2;
Console.WriteLine(dynamicObject2.GetType());
dynamicObject2.Name = "DynamicObject2";