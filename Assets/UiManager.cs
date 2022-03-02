using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text Score;
    public Text endScore;
    public GameObject startPage;
    public GameObject endPage;
    // Start is called before the first frame update
    void Start()
    {
        endPage.SetActive(false);
        startPage.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Score.text ="Score : "+ Data.score.ToString();
    }
}
