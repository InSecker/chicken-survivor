using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{   
    public Text TxtBullet;
    public GameObject ObjPrefabs;
    public float Duree = 5;
    
    

    bool IsLoaded = true;
    // Start is called before the first frame update
    void Start()
    {
        TxtBullet.text = "Loaded";
    }

    // Update is called once per frame
    void Update()
    {
        float fire = Input.GetAxis("Fire1");

        if (fire > 0.1f && IsLoaded){
            Debug.Log("ok");
            GameObject bullet = GameObject.Instantiate(ObjPrefabs);
            Vector3 persoPos = GameObject.Find("Personnage").transform.position;
            bullet.transform.position = persoPos;
            IsLoaded = false;
            Debug.Log("wait");
            Invoke("Loading",Duree);
            TxtBullet.text = "Loading";
        }
        
    }

    void Loading(){
        IsLoaded = true;
        Debug.Log("Loaded");
        TxtBullet.text = "Loaded";
    }
}
