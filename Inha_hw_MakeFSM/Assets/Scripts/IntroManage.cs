using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �� ��ȯ�� �־������ ���

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
