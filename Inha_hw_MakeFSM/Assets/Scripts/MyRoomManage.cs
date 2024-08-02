using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyRoomManage : MonoBehaviour
{
    GameObject nameText;
    GameObject goldText;
    GameObject hpText;
    GameObject weaponText;

    float span = 0.1f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enter MyRoomScene");
        this.nameText = GameObject.FindWithTag("Name");
        this.goldText = GameObject.FindWithTag("Gold");
        this.hpText = GameObject.FindWithTag("Hp");
        this.weaponText = GameObject.FindWithTag("Weapon");
        this.nameText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.name;
        this.goldText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.gold;
        this.hpText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.hp;
        this.weaponText.GetComponent<TextMeshProUGUI>().text += SceneCHManage.instance.weapon_level;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            if (SceneCHManage.instance.hp < 100)
            {
                SceneCHManage.instance.hp += 1;
                this.hpText.GetComponent<TextMeshProUGUI>().text = "Hp : " + SceneCHManage.instance.hp;
            }
        }
    }

    private void OnDestroy()
    {
        Debug.Log("Exit MyRoomScene");
    }
}
