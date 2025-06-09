using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lake
{
    private static Lake instance = null;
    private IDuckFactory duckFactory = null;

    private List<Duck> Ducks;

    private Lake()
    {
        duckFactory = new DuckFactory();

        // Inserindo Patos Pré-definidos
        List<Duck> _ducks = new List<Duck>();
        _ducks.Add(duckFactory.CreateDuck(DuckType.Mallard, "verde"));
        _ducks.Add(duckFactory.CreateDuck(DuckType.RedHead, "vermelho"));
        _ducks.Add(duckFactory.CreateDuck(DuckType.Rubber, "amarelo"));
        _ducks.Add(duckFactory.CreateDuck(DuckType.Marreco, "marrom"));
        _ducks.Add(duckFactory.CreateDuck(DuckType.Mute, "..."));
        _ducks.Add(duckFactory.CreateDuck(DuckType.Cayuga, "verde-água"));

        SetDucks(_ducks);
    }

    public static Lake GetInstance()
    {
        if (instance == null)
        {
            instance = new Lake();
        }

        return instance;
    }

    public void SetDucks(List<Duck> _ducks)
    {
        Ducks = _ducks;
    }

    public List<Duck> GetDucks()
    {
        return Ducks;
    }

    public void Notify(bool active)
    {
        for(int i = 0; i < Ducks.Count; i++)
        {
            Ducks[i].Update(active);
        }
    }
}