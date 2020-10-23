using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SFXPlayer : MonoBehaviour
{
    [SerializeField] private List<AudioClip> clips;
    public void PlayClip(AudioClip clip)
    {
        var audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();
    }
    public void PlayClip(int index)
    {
        PlayClip(clips[index]);
    }
}
