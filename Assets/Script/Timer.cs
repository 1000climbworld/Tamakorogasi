using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float countTime = 60;
    int seconds;

	void Update () {
        if(countTime >= 0){
            countTime -= Time.deltaTime;
            seconds = (int)countTime;
            GetComponent<Text>().text = seconds.ToString();
        }
    }
}
