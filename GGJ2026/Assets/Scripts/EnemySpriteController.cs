using UnityEngine;
using System.Collections;

public class EnemySpriteController : MonoBehaviour
{
    public Sprite idleSprite;

    public Sprite dancingSprite1;
    public Sprite dancingSprite2;

    public Sprite singingSprite1;
    public Sprite singingSprite2;

    public Sprite actingSprite1;
    public Sprite actingSprite2;

    public Sprite defeatedSprite;

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
                yield return PlayTwoSprites(dancingSprite1, dancingSprite2);
                break;

            case ActType.Singing:
                yield return PlayTwoSprites(singingSprite1, singingSprite2);
                break;

            case ActType.Acting:
                yield return PlayTwoSprites(actingSprite1, actingSprite2);
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
