using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Data.score>=100)
        {
            FindObjectOfType<PLayerControll>().canMove = false;
            UiManager uiMan = FindObjectOfType<UiManager>();
            uiMan.endScore.text="Score : "+100;
            uiMan.endPage.SetActive(true);
        }
    }
    public void Restart()
    {
        Data.score = 0;
        Data.prefabCount = 0;
        SceneManager.LoadScene(0);
    }
}
