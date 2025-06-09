using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum DuckType
{
    Duck,
    Cayuga,
    Mallard,
    Marreco,
    Mute,
    RedHead,
    Rubber
}

public interface IDuckFactory
{
    Duck CreateDuck(DuckType type, string cor);
}

public class DuckFactory : IDuckFactory
{
    public Duck CreateDuck(DuckType type, string cor)
    {
        switch (type)
        {
            case DuckType.Duck:
                return new Duck(cor);
            case DuckType.Cayuga:
                return new CayugaDuck(cor);
            case DuckType.Mallard:
                return new MallardDuck(cor);
            case DuckType.Marreco:
                return new MarrecoDuck(cor);
            case DuckType.Mute:
                return new MuteDuck(cor);
            case DuckType.RedHead:
                return new RedHeadDuck(cor);
            case DuckType.Rubber:
                return new RubberDuck(cor);
        }
        return new Duck(cor);
    }
}