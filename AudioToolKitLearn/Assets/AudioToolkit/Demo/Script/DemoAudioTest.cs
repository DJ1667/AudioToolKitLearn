using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoAudioTest : MonoBehaviour
{
    public void PlayMusic1()
    {
        AudioManager.Instance.PlayMusic(AudioName.BGM1);
    }

    public void PlayMusic2()
    {
        AudioManager.Instance.PlayMusic(AudioName.BGM2);
    }

    public void PlaySound1()
    {
        AudioManager.Instance.Play(AudioName.Sound1);
    }

    public void PlaySound2()
    {
        AudioManager.Instance.Play(AudioName.Sound2);
    }
}
