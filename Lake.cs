using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Lake
{
    private static Lake instance = null;

    private List<Duck> Ducks;

    private Lake()
    {
        // Inserindo Patos Pré-definidos
        List<Duck> _ducks = new List<Duck>();
        _ducks.Add(new MallardDuck("verde"));
        _ducks.Add(new RedHeadDuck("vermelho"));
        _ducks.Add(new RubberDuck("amarelo"));
        _ducks.Add(new MarrecoDuck("marrom"));
        _ducks.Add(new MuteDuck("..."));
        _ducks.Add(new CayugaDuck("verde-água"));

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
}
