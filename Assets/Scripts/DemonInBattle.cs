using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemonInBattle : MonoBehaviour
{
    public Text nameText;
    public Text levelText;
    public Image sprite;
    public Demon demon;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = demon.demonName;
        levelText.text = demon.stats.GetStatValue(BaseStats.Lvl).ToString();
        sprite.sprite = demon.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initialize(Demon demonInit)
    {
        demon = demonInit;
    }
}
