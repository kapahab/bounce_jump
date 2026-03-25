using System.Collections;
using System.Numerics;
using DG.Tweening;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MoveSideway : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rightLimit;
    public float leftLimit;

    public float speed;
    private Transform t;
    void Start()
    {
        t = transform;
        StartCoroutine(KeepMovingSideways());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator KeepMovingSideways()
    {
        while (true)
        {
            bool animPlaying = true;

            t.DOMoveX(rightLimit, speed).SetEase(Ease.OutSine).OnComplete((() => 
                    t.DOMoveX(leftLimit,speed).SetEase(Ease.OutSine).OnComplete((() => 
                        animPlaying = false))));

            yield return new WaitUntil(() => !animPlaying);
        }
    }
}
