using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public DemonInBattle demon1;
    // Start is called before the first frame update
    void Start()
    {
        var encounters = OverworldManager.instance.encounters.encounterTable;
        demon1.Initialize(encounters[Random.Range(0, encounters.Count)]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
