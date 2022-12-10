using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    public PokemonBase Base { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }

    public List<Moves> Moves { get; set; }
    public Pokemon(PokemonBase pBase, int pLevel)
    {
        Base = pBase;
        Level = pLevel;
        HP = MaxHP;

        Moves = new List<Moves>();
        foreach (var moves in Base.LearnableMoves)
        {
            if (moves.Level <= Level)
                Moves.Add(new Moves(moves.Base));

            if (Moves.Count >= 4)
                break;
        }
    }

    public int MaxHP
    {
        get { return (int)((Base.MaxHP * Level) / 100f) + 10; }
    }

    public int Attack
    {
        get { return (int)((Base.Attack * Level) / 100f) + 5; }
    }

    public int Defence
    {
        get { return (int)((Base.Defence * Level) / 100f) + 5; }
    }

    public int SpAttack
    {
        get { return (int)((Base.SpAttack * Level) / 100f) + 5; }
    }

    public int SpDefence
    {
        get { return (int)((Base.SpDefence * Level) / 100f) + 5; }
    }
    public int Speed
    {
        get { return (int)((Base.Speed * Level) / 100f) + 5; }
    }


}
