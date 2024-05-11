using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCar : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public Transform spawnPoint;
    public TMP_Text label;

    void Start(){
        int selectedCar = PlayerPrefs.GetInt("selectedCar");
        print("Selected car: " + selectedCar);
        GameObject prefab = carPrefabs[selectedCar];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        clone.SetActive(true); 
        clone.transform.rotation = spawnPoint.rotation;
        label.text = prefab.name;
    }
}
