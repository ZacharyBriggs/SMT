using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;
    public DemonInBattle demon1;
    public DemonInBattle player;
    public DemonInBattle playerDemon1;
    public DemonInBattle currentAttacker;
    public bool isPlayersTurn;

    void Start()
    {
        instance = this;
        var encounters = OverworldManager.instance.encounters.encounterTable;
        demon1.Initialize(encounters[Random.Range(0, encounters.Count)]);
        player.Initialize(OverworldManager.instance.playerScriptable);
        playerDemon1.Initialize(OverworldManager.instance.playerDemons[0]);
    }

}
