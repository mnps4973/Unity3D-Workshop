using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseCondition : MonoBehaviour
{
    public GameObject player;
    bool m_isPlayerAtEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject == player){
            m_isPlayerAtEnd = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(m_isPlayerAtEnd){
            SceneManager.LoadScene("UI_End");
        }
    }
}
