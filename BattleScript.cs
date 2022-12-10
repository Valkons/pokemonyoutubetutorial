using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleScript : MonoBehaviour
{
    [SerializeField] BattleTrainer TrainerPokemon;
    [SerializeField] BattleHUD battleHUD;

    private void Start()
    {
        SetupBattle();
    }

    public void SetupBattle()
    {
        TrainerPokemon.Setup();
        BattleHUD.SetData(TrainerPokemon.Pokemon);
    }
}