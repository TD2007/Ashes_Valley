using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btnCredit;
    public Button btnStart;
    public void LoadCreditScene(){
        SceneManager.LoadScene("CreditScene");
    }
    public void LoadGameScene(){
        SceneManager.LoadScene("DemoScene");
    }
    void Start()
    {
        btnCredit = GameObject.Find("Menu/Panel/CreditBtn").GetComponent<Button>();
        btnCredit.onClick.AddListener(LoadCreditScene);
        btnCredit = GameObject.Find("Menu/Panel/StartBtn").GetComponent<Button>();
        btnCredit.onClick.AddListener(LoadGameScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
