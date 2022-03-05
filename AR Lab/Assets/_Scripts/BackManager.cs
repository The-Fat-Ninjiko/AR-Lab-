using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackManager : MonoBehaviour
{
public static BackManager instance;
    public bool back;
 void Awake() {
if(instance==null) 
instance = this;
else 
Destroy(gameObject);

DontDestroyOnLoad(gameObject);
}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "Atoms"|| SceneManager.GetActiveScene().name == "Fire&Water") { 
            SceneManager.LoadScene("MenuScene");
            }
            else { 
            Application.Quit();
        }
        }
    }
}
