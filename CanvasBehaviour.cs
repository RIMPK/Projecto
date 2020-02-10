using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasBehaviour : MonoBehaviour
{
    public InputField name;
    public Slider volumen;
    public Toggle subtitulos;
    public void SaveOPtions()
    {
        PlayerPrefs.SetString("name", name.text);
        PlayerPrefs.SetFloat("Volumen", volumen.value);
        int sub = subtitulos.isOn ? 1 : 0;
        PlayerPrefs.SetInt("subtitulos", sub);

        PlayerPrefs.Save();

        Debug.Log(PlayerPrefs.GetString("name"));
        Debug.Log(PlayerPrefs.GetFloat("Volumen"));
        Debug.Log(PlayerPrefs.GetInt("subtitulos"));
    }
}
