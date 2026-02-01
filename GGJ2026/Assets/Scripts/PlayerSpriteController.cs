using UnityEngine;
using System.Collections;

public class PlayerSpriteController : MonoBehaviour
{
    public Sprite idleSprite;

    [Header("Dancing Sprites")]
    public Sprite dancingSprite1;
    public Sprite dancingSprite2;

    [Header("Singing Sprites")]
    public Sprite singingSprite1;
    public Sprite singingSprite2;

    [Header("Acting Sprites")]
    public Sprite actingSprite1;
    public Sprite actingSprite2;

    private SpriteRenderer spriteRenderer;
    private Coroutine currentRoutine;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = idleSprite;
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
                yield return StartCoroutine(PlayTwoSprites(dancingSprite1, dancingSprite2));
                break;

            case ActType.Singing:
                yield return StartCoroutine(PlayTwoSprites(singingSprite1, singingSprite2));
                break;

            case ActType.Acting:
                yield return StartCoroutine(PlayTwoSprites(actingSprite1, actingSprite2));
                break;
        }

        spriteRenderer.sprite = idleSprite;
    }

    private IEnumerator PlayTwoSprites(Sprite first, Sprite second)
    {
        spriteRenderer.sprite = first;
        yield return new WaitForSeconds(0.5f);

        spriteRenderer.sprite = second;
        yield return new WaitForSeconds(0.5f);
    }
}
