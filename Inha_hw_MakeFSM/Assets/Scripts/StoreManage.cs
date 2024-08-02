using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enter StoreScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Debug.Log("Exit StoreScene");
    }
}
