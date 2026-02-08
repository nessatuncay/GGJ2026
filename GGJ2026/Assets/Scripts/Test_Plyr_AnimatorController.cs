using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animator;
/*
    [Header("Dancing Sprites")]
    public Sprite dancingSprite1;
    public Sprite dancingSprite2;

    [Header("Singing Sprites")]
    public Sprite singingSprite1;
    public Sprite singingSprite2;

    [Header("Acting Sprites")]
    public Sprite actingSprite1;
    public Sprite actingSprite2;
*/
    private SpriteRenderer spriteRenderer;
    private Coroutine currentRoutine;

    void Awake()
    {
        animator = GetComponent<Animator>();
        animator.Play("Idle");
    }

    public void PlayAct(ActType act)
    {
        if (currentRoutine != null)
            StopCoroutine(currentRoutine);

        currentRoutine = StartCoroutine(PlayActRoutine(act));
    }

    private IEnumerator PlayActRoutine(ActType act)
    {
        switch (act)
        {
            case ActType.Dancing:
                yield return StartCoroutine(PlayTwoSprites("Dancing"));
                break;

            case ActType.Singing:
                yield return StartCoroutine(PlayTwoSprites("Singing"));
                break;

            case ActType.Acting:
                yield return StartCoroutine(PlayTwoSprites("Acting"));
                break;
        }
        
        // animator.Play("Idle");

    }

    private IEnumerator PlayTwoSprites(string act)
    {
        animator.Play(act);
        yield return null;
        // new WaitForSeconds(0.5f);

        //spriteRenderer.sprite = second;
        //yield return new WaitForSeconds(0.5f);
    }
}
