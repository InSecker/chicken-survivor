using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public int LifeCount = 5;

    public Text TxtLife; 

    void Start() {
        TxtLife.text = "Vies : " + LifeCount;
    }

    public void AddLife() {
        LifeCount++;

        TxtLife.text = "Vies : " + LifeCount;
    }

    public void RemoveLife() {
        LifeCount--;

        TxtLife.text = "Vies : " + LifeCount;

        if (LifeCount <= 0) {
            // Recharger la scène
            SceneManager.LoadScene("Lose");

        }
    }

}
