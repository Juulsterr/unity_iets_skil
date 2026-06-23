using UnityEngine;

public class Tank : MonoBehaviour
{

    float horizontalInput;
    float verticalInput;
    [SerializeField] Bullet bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = -Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * verticalInput * 5);
        transform.Rotate(Vector3.forward * Time.deltaTime * horizontalInput * 100);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet instanceofBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            instanceofBullet.direction = transform.right;
        }
    }
}
