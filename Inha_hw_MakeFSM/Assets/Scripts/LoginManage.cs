using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enter LoginScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Debug.Log("Exit LoginScene");
    }
}
