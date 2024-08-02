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
        if (instance == null) //instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; //���ڽ��� instance�� �־��ݴϴ�.
            DontDestroyOnLoad(gameObject); //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� Awake�� �ڽ��� ����
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
