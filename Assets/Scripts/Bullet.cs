using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 direction = Vector3.right;
    public float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
          Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("BlueTank"))
        {
            Destroy(gameObject);
        }
    }
    
}
