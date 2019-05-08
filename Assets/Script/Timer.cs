using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float countTime = 100;
    int seconds;

	void FixedUpdate () {
        if(countTime >= 0){
            countTime -= Time.deltaTime;
            seconds = (int)countTime;
            GetComponent<Text>().text = "Time:   "+ seconds.ToString();
        }
    }
}
