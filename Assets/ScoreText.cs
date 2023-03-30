using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using FOGPIUtilities.Manager;

public class ScoreText : MonoBehaviour
{
    void Start()
    {
        if (ScoreManager.instance == null)
        {
            Debug.LogWarning("ScoreManager is null");
            return;
        }

        Debug.Log(ScoreManager.instance.score.ToString());
    }

    public void UpdateText(ScoreInfo _scoreInfo)
    {
        TMP_Text scoreText = gameObject.GetComponent<TMP_Text>();
        scoreText.text = _scoreInfo.score.ToString();
    }
}
