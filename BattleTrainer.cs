using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTrainer : MonoBehaviour
{
    [SerializeField] PokemonBase _base;
    [SerializeField] int level;
    [SerializeField] bool isTrainerPoke;

    public Pokemon Pokemon { get; set; }
    public void Setup()
    {
        Pokemon = new Pokemon(_base, level);
        if (isTrainerPoke)
        {
            GetComponent<Image>().sprite = Pokemon.Base.BackSprite;
        }
        else
        {
            GetComponent<Image>().sprite = Pokemon.Base.FrontSprite;
        }
    }
}
