using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Minu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject optionspanel;
    public AudioSource as1;
    public float musevolume;




    void Start()
    {
        as1 = GetComponent<AudioSource>();
    }

    public void Setvolume(float vol)
    {
        musevolume = vol;
    }


    public void Goptions()
    {
        optionspanel.SetActive(true);

        menupanel.SetActive(false);
    }
    public void GoMenu()
    {
        optionspanel.SetActive(false);

        menupanel.SetActive(true);
    }




    public void Nextlevel()
    {
        SceneManager.LoadScene("level1");
    }

    public void Exit()
    {
        Application.Quit();
    }

 
    void Update()
    {
      as1.volume = musevolume;
    }
}
