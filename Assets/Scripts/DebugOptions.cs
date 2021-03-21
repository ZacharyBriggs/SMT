using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugOptions : MonoBehaviour
{
    public void StartBattle()
    {
        SceneManager.LoadScene("BattleScene");
    }
}
