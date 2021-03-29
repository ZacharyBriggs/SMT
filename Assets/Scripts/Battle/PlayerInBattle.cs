using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInBattle : MonoBehaviour
{
    public Text nameText;
    public Text levelText;
    public Image sprite;
    public PlayerBattleScriptable player;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = player.demonName;
        levelText.text = player.stats.GetStatValue(BaseStats.Lvl).ToString();
        sprite.sprite = player.sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Initialize()
    {

    }
}
