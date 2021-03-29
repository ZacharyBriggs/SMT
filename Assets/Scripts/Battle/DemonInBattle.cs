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
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initialize(Demon demonInit)
    {
        demon = demonInit;
        nameText.text = demon.demonName;
        levelText.text = demon.stats.GetStatValue(BaseStats.Lvl).ToString();
        sprite.sprite = demon.sprite;
    }
}
