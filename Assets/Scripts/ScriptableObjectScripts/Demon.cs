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
    Avian,
    Human
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
    Almighty,
    Ailment,
    Heal,
    Support
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

public enum Alignment
{
    Law,
    Neutral,
    Chaos,
}

public enum SubAlignment
{
    Light,
    Neutral,
    Dark,
}

[CreateAssetMenu(fileName = "NewDemon", menuName = "ScriptableObjects/Create New Demon")]
public class Demon : ScriptableObject
{
    public Sprite sprite;
    public Race race;
    public string demonName;
    public Alignment alignment;
    public SubAlignment subAlignment;
    public Stats stats = new Stats();
    public List<Resistance> resistances = new List<Resistance>();
    public List<Affinity> affinities = new List<Affinity>();
    public List<Skill> skills = new List<Skill>();

    public Demon()
    {
        stats.Initialize();
        foreach(Element ele in Enum.GetValues(typeof(Element)))
        {
            resistances.Add(new Resistance(ele, ResistanceType.None));
            affinities.Add(new Affinity(ele, 0));
        }
        for (int i = 0; i < 8; i++)
        {
            skills.Add(null);
        }
    }
}
