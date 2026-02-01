using UnityEngine;

public class PlayerSpriteController : MonoBehaviour
{
    public Sprite idleSprite;

    public Sprite dancingSprite;
    public Sprite singingSprite;
    public Sprite actingSprite;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = idleSprite;
    }

    public void ShowActSprite(ActType act)
    {
        switch (act)
        {
            case ActType.Dancing:
                spriteRenderer.sprite = dancingSprite;
                break;

            case ActType.Singing:
                spriteRenderer.sprite = singingSprite;
                break;

            case ActType.Acting:
                spriteRenderer.sprite = actingSprite;
                break;
        }
    }

    public void ShowIdle()
    {
        spriteRenderer.sprite = idleSprite;
    }
}
