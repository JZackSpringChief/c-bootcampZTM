public interface ICar
{
    string GetModel();
    int GetTopSpeed();
}

public class ToyotaTacoma : ICar
{
    public string GetModel()
    {
        return "Toyota Tacoma";
    }

    public int GetTopSpeed()
    {
        return 300;
    }
}

public class NissanZ : ICar
{
    public string GetModel()
    {
        return "Nissan Z";
    }

    public int GetTopSpeed()
    {
        return 400;
    }
}