using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Operation
{
    Add,
    Multiply,
    Subtract,
    Divide,
}

public class Modifier
{
    public int value;
    public BaseStats modifiedStat;
    public Operation operation;
}