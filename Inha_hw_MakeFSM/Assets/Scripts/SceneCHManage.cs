using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCHManage : MonoBehaviour
{
    enum SCENE { INTRO, LOGIN, LOBBY, STORE, BATTLE, MYROOM, EVOLUTION };
    public static SceneCHManage instance = null;
    [Header ("Player")]
    public string name;
    public int hp;
    public int gold;
    public int weapon_level;
    private void Awake()
    {
        if (instance == null) //instance가 null. 즉, 시스템상에 존재하고 있지 않을때
        {
            instance = this; //내자신을 instance로 넣어줍니다.
            DontDestroyOnLoad(gameObject); //OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
        }
        else
        {
            if (instance != this) //instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
                Destroy(this.gameObject); //둘 이상 존재하면 안되는 객체이니 방금 Awake된 자신을 삭제
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CH_Scene()
    {
        //SceneManager.LoadScene();
    }
    public void Goto_Login()
    {
        SceneManager.LoadScene("LoginScene");
    }
    public void Goto_Lobby()
    {
        SceneManager.LoadScene("LobbyScene");
    }
    public void Goto_Store()
    {
        SceneManager.LoadScene("StoreScene");
    }
    public void Goto_Battle()
    {
        SceneManager.LoadScene("BattleScene");
    }
    public void Goto_MyRoom()
    {
        SceneManager.LoadScene("MyRoomScene");
    }
    public void Goto_Evolution()
    {
        SceneManager.LoadScene("EvolutionScene");
    }
}
