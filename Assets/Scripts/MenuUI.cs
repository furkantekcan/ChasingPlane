using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public Button playButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }

    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectPlane(int planeIndex)
    {
        PlayerPrefs.SetInt("planeIndex", planeIndex);
    }
}
