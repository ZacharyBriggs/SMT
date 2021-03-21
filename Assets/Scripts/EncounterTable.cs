using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEncounterTable", menuName = "ScriptableObjects/Create New Encounter Table")]
public class EncounterTable : ScriptableObject
{
    public List<Demon> encounterTable = new List<Demon>();
}
