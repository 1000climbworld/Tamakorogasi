using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

<<<<<<< HEAD
    public float countTime = 60;
    int seconds;
=======
    public float countTime = 100;
    int seconds;
>>>>>>> 8eaf0340a06933b28cc9d1c998799dfd5f1647c5

	void FixedUpdate () {
        if(countTime >= 0){
            countTime -= Time.deltaTime;
            seconds = (int)countTime;
<<<<<<< HEAD
            GetComponent<Text>().text = seconds.ToString();
        }
=======
            GetComponent<Text>().text = "Time:   "+ seconds.ToString();
        }
>>>>>>> 8eaf0340a06933b28cc9d1c998799dfd5f1647c5
    }
}
