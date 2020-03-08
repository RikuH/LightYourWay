using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Button StartBtn;
    public Button CreditsBtn;
    public Button BackBtn;
    public Button QuitBtn;

    public GameObject CreditsPanel;
    public GameObject MainPanel;
    // Start is called before the first frame update
    void Start()
    {
        StartBtn.onClick.AddListener(StartGame);
        CreditsBtn.onClick.AddListener(CreditsPanelActive);
        BackBtn.onClick.AddListener(BackToMain);
        QuitBtn.onClick.AddListener(QuitGame);
    }


    void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    void QuitGame()
    {
        Application.Quit();
    }

    void CreditsPanelActive()
    {
        CreditsPanel.SetActive(true);
        MainPanel.SetActive(false);

    }

    void BackToMain()
    {
        CreditsPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
}
