using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Race
{
    Fairy,
    Jirae,
    Megami,
    Femme,
    Beast,
    Spirit,
    Ghost,
    Avian
}

public enum Element
{
    Physical,
    Gun,
    Fire,
    Ice,
    Elec,
    Force,
    Light,
    Dark,
    Almighty
}

public enum ResistanceType
{
    None,
    Weak,
    Resist,
    Null,
    Drain,
    Reflect
}

[CreateAssetMenu(fileName = "NewDemon", menuName = "ScriptableObjects/Create New Demon")]
public class Demon : ScriptableObject
{
    public Sprite sprite;
    public Race race;
    public string demonName;
    public List<Stat> stats = new List<Stat>();
    public List<Resistance> resistances = new List<Resistance>();
    public List<Affinity> affinities = new List<Affinity>();

    public Demon()
    {
        stats = new List<Stat>();
        foreach(BaseStats bs in Enum.GetValues(typeof(BaseStats)))
        {
            stats.Add(new Stat(bs, 0));
        }

        foreach(Element ele in Enum.GetValues(typeof(Element)))
        {
            resistances.Add(new Resistance(ele, ResistanceType.None));
            affinities.Add(new Affinity(ele, 0));
        }
    }
}
