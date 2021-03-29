using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackMenu : MonoBehaviour
{
    public Skill currentSkill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SkillButtonPressed(Text text)
    {
        //swtich to target select
        var path = "ScriptableObjects/Skills/" + text.text;
        currentSkill = Resources.Load(path)as Skill;
        if(currentSkill.targetType == TargetType.Single)
        {
            BattleManager.instance.demon1.button.interactable = true;
        }
    }
}
