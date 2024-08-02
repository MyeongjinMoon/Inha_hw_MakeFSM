using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // 씬 전환시 넣어줘야할 요소

public class IntroManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enter IntroScene");
    }
    private void OnDestroy()
    {
        Debug.Log("Exit IntroScene");
    }
}
