using UnityEngine;

public class falling_object : MonoBehaviour
{
    public float speed = 3f;
    private float bottomLimit;

    void Start()
    {
        // bottom of screen in world space
        bottomLimit = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y - 1f;
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // If object goes off screen, destroy it
       /* if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }*/
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}