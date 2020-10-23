using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int ScoreCount = 0;
    public Text TextScore; 
    // Start is called before the first frame update
    void Start()
    {
        TextScore.text = "Score : " + ScoreCount;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreCount += (int)(Time.deltaTime*100);
        TextScore.text = "Score : " + ScoreCount;
    }
}
