using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTrigger : MonoBehaviour
{
    public GameObject halfLapTrigger;
    public GameObject finishLapTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            finishLapTrigger.SetActive(true);
            halfLapTrigger.SetActive(false);
        }
    }
}
