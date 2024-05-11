using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class CarSelection : MonoBehaviour
{
    public GameObject[] cars;
    public int selectedCar = 0;

    public void nextCar()
    {
        cars[selectedCar].SetActive(false);
        selectedCar = 1;
        cars[selectedCar].SetActive(true);
        PlayerPrefs.SetInt("selectedCar", selectedCar);
    }

    public void previousCar(){
        cars[selectedCar].SetActive(false);
        selectedCar = 0;
        cars[selectedCar].SetActive(true);
        PlayerPrefs.SetInt("selectedCar", selectedCar);
    }

    public void StartGame(){
        PlayerPrefs.SetInt("selectedCar", selectedCar);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
