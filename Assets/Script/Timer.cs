using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float countTime = 100;
    int seconds;

    void Start()
    {

    }

    void FixedUpdate () {
        if(countTime >= 0){
            countTime -= Time.deltaTime;
            seconds = (int)countTime;
            GetComponent<Text>().text = seconds.ToString();
        }

    }

    void Update()
    {
        if (seconds == 0 || Time.timeScale == 0.0f)
        {
            StartCoroutine("Load");
        }
    }


    private IEnumerator Load()
    {
        Time.timeScale = 1.0f;
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
