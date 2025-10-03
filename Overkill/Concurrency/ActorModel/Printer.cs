namespace Overkill.Concurrency.ActorModel;

public class Printer : Actor
{
    public void Print()
    {
        _ = SendAsync(Work);
        return;

        Task Work()
        {
            Console.WriteLine("Printing...");
            return Task.CompletedTask;
        }
    }
}