using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = (Player.position.x + 14).ToString("0");

    }
}
