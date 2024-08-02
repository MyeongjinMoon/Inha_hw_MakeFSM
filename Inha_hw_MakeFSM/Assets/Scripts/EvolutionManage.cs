using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EvolutionManage : MonoBehaviour
{
    GameObject nameText;
    GameObject goldText;
    GameObject hpText;
    GameObject weaponText;
    GameObject WantGoldText;
    GameObject timeText;

    float span = 5.0f;
    float delta = 0;
    float time = 5.0f;

    void Start()
    {
        Debug.Log("Enter EvolutionScene");
        this.nameText = GameObject.FindWithTag("Name");
        this.goldText = GameObject.FindWithTag("Gold");
        this.hpText = GameObject.FindWithTag("Hp");
        this.weaponText = GameObject.FindWithTag("Weapon");
        this.timeText = GameObject.FindWithTag("Time");
        this.WantGoldText = GameObject.FindWithTag("WantGold");
        this.nameText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.name;
        this.goldText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.gold;
        this.hpText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.hp;
        this.weaponText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.weapon_level;
        this.WantGoldText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.weapon_level * 100;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        this.time -=Time.deltaTime;
        this.timeText.GetComponent<TextMeshProUGUI>().text = "Time : " + this.time.ToString("F1");
        if (this.delta > this.span)
        {
            this.delta = 0;
            this.time = 5.0f;
            if (SceneCHManage.instance.gold >= 100 * SceneCHManage.instance.weapon_level)
            {
                SceneCHManage.instance.gold -= 100 * SceneCHManage.instance.weapon_level;
                if (Random.Range(0, 5) == 0)
                {
                    if (SceneCHManage.instance.weapon_level != 1)
                        SceneCHManage.instance.weapon_level--;
                }
                else
                {
                    SceneCHManage.instance.weapon_level++;
                    GetComponent<ParticleSystem>().Play();
                }
                this.weaponText.GetComponent<TextMeshProUGUI>().text = "Weapon : " + SceneCHManage.instance.weapon_level;
                this.goldText.GetComponent<TextMeshProUGUI>().text = "Gold : " + SceneCHManage.instance.gold;
                this.WantGoldText.GetComponent<TextMeshProUGUI>().text = "Want Gold : " + SceneCHManage.instance.weapon_level * 100;
            }
        }
    }

    private void OnDestroy()
    {
        Debug.Log("Exit EvolutionScene");
    }
}
