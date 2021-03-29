using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BaseStats
{
    Lvl,
    Exp,
    MaxExp,
    HP,
    MaxHP,
    MP,
    MaxMP,
    Str,
    Dex,
    Mag,
    Vit,
    Agi,
    Luc,
}

[Serializable]
public class Stat
{
    public BaseStats baseStat;
    public int value;
    private Dictionary<int, Modifier> mods = new Dictionary<int, Modifier>();

    public Stat(BaseStats bStat, int statValue)
    {
        baseStat = bStat;
        value = statValue;
    }

    public void AddModifier(int id, Modifier mod)
    {
        mods.Add(id, mod);
    }

    public void RemoveModifier(int id)
    {
        mods.Remove(id);
    }

    public Modifier GetModifier(int id)
    {
        return mods[id];
    }

}

[Serializable]
public class Resistance
{
    public Element element;
    public ResistanceType resistType;
    public Resistance(Element ele, ResistanceType rt)
    {
        element = ele;
        rt = resistType;
    }
}

[Serializable]
public class Affinity
{
    public Element element;
    public int affinityLevel;
    public Affinity(Element ele, int al)
    {
        element = ele;
        affinityLevel = al;
    }
}
