using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType
{
    Single,
    MultiTarget,
    Enemies,
    Allies,
    Self
}

public enum DamageAmount
{
    Basic,
    Light,
    Medium,
    Heavy,
    Severe
}

[CreateAssetMenu(fileName = "NewSkill", menuName = "ScriptableObjects/Create New Skill")]
public class Skill : ScriptableObject
{
    public string attackName;
    public string description;
    public Element element;
    public DamageAmount damageAmount;
    public TargetType targetType;
}
