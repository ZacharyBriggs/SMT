using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stats
{
    public List<Stat> statList = new List<Stat>();
    
    public void Initialize()
    {
        statList = new List<Stat>();
        foreach (BaseStats bs in Enum.GetValues(typeof(BaseStats)))
        {
            statList.Add(new Stat(bs, 0));
        }
    }

    public int GetStatValue(BaseStats baseStat)
    {
        for(int i = 0; i < Enum.GetValues(typeof(BaseStats)).Length; i++)
        {
            if(statList[i].baseStat == baseStat)
                return statList[i].value;
        }
        Debug.LogError("Invalid Base Stat Entered");
        return 0;
    }
}
