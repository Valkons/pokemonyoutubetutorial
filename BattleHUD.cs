using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class BattleHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PokeName;
    [SerializeField] TextMeshProUGUI PokeLevel;
    [SerializeField] BattleHPBar hpBar;

    public void SetData(Pokemon pokemon)
    {
        PokeName.text = pokemon.Base.Name;
        PokeLevel.text = "Lv. " + pokemon.Level;
        hpBar.SetHP((float)pokemon.HP / pokemon.MaxHP);
    }

    internal static void SetData(PokemonBase @base)
    {
        throw new NotImplementedException();
    }
}
