using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{

    public TMP_Text timer;
    private int i = 0;
    private int endTimer = 1000;

    // Update is called once per frame
    void FixedUpdate() {

        timer.text = "00:0" + ((endTimer - i)/100).ToString() + ":" + ((endTimer - i)).ToString();
        i++;

        if (i > 1000) {
            SceneManager.LoadScene("Interchange");
        } 
    }
}
