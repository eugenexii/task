using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    private void Update()
    {
        scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = "Score: " + theScore;
    }
}
