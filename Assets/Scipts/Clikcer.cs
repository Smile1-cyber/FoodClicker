using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Clikcer : MonoBehaviour
{
    [Header("Animation settings")]
    public float scale = 1.2f;
    public float duration = 0.1f;
    public Ease ease;

    [Header("Sound")]
    public AudioClip clicksound;

    private AudioSource audiosource;

    private int clicks = 0;
    
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }


    private void OnMouseDown() 
    {
        clicks++;
        UiManager.instance.UpdateClicks(clicks);
        audiosource.pitch = Random.Range(0.9f, 1.1f);
        audiosource.PlayOneShot(clicksound);
        transform
            .DOScale(1, duration)
            .ChangeStartValue(scale * Vector3.one)
            .SetEase(ease);
            //.SetLoops(2, LoopType.Yoyo);
    }
}
