using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioClip[] BGMList;
    [SerializeField] AudioClip[] SFXList;
    [SerializeField] AudioSource BGMAS;
    [SerializeField] AudioSource SFXAS;
    
    public void PlaySFX(int index)
    {
        SFXAS.PlayOneShot(SFXList[index]);
    }

    public void PlayBGM(int index)
    {
        BGMAS.Stop();
        BGMAS.clip = BGMList[index];
        BGMAS.Play();
    }

    public void StopBGM()
    {
        BGMAS.Stop();
    }
}
