public interface IWorker
{
    void Work();
    void TakeBreak();
    void GetPaid();
}

public class HumanWorker : IWorker
{
    public void Work()
    {
        
    }

    public void TakeBreak()
    {

    }

    public void GetPaid()
    {

    }
}

public class RobotWorker : IWorker
{
    public void Work()
    {

    }

    public void TakeBreak()
    {
        throw new NotImplementedException("This method is unnecessary for the robots");
    }

    public void GetPaid()
    {
        throw new NotImplementedException("This method is unnecessary for the robots");
    }
}