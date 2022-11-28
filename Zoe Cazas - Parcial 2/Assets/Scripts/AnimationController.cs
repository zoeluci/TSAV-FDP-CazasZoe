using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public float timer;
    public float loopEndTime = 1.0f;

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        animator.SetFloat("Blend", timer);

        if (timer >= loopEndTime)
        {
            timer = 0.0f;
        }
    }
}
