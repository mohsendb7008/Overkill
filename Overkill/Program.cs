using Overkill.Collection;

var magicList = new MagicList();
string input;
do
{
    input = Console.ReadLine()!;
    var split = input.Split(" ");
    switch (split[0])
    {
        case "1":
            magicList.Init();
            break;
        case "2":
            magicList.Null();
            break;
        case "3":
        {
            var success = magicList.Add(int.Parse(split[1]));
            if (!success)
                Console.WriteLine("nulle");
            break;
        }
        case "4":
            Console.WriteLine(magicList.Get(int.Parse(split[1])));
            break;
        case "5":
        {
            var m = int.Parse(split[1]);
            var n = int.Parse(split[2]);
            try
            {
                Console.WriteLine(m / n);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("sefre");
            }
            break;
        }
    }
} while(!input.Equals("6"));