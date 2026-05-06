using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button newGameBtn;
    public Button continueBtn;
    public Button quitBtn;


    private void Awake()
    {
        newGameBtn.onClick.AddListener(NewGame);
        continueBtn.onClick.AddListener(ContinueGame);
        quitBtn.onClick.AddListener(QuitGame);
    }

    
    void NewGame()
    {
        PlayerPrefs.DeleteAll();
        //转换场景
        SceneController.Instance.TransitionToFirstLevel();
    }

    void ContinueGame()
    {

    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("退出游戏");
    }
}
