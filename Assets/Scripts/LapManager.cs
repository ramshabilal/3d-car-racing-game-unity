using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapManager : MonoBehaviour
{
    public GameObject YouWinPanel;
    public AudioSource winAudio;
    public Text lapCountText;

    public int totalLaps = 3;
    private int currentLap = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentLap++;
            lapCountText.text = "Lap: " + currentLap.ToString() + "/" + totalLaps.ToString();
            
            if (currentLap >= totalLaps)
            {
                YouWinPanel.SetActive(true);
                winAudio.Play();
                Time.timeScale = 0f;
            }
        }
    }
}
