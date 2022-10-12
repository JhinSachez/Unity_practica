
using UnityEngine;

public class Crate : MonoBehaviour
{
    public SpawnController controller;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * controller.currentspeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            controller.generatecrate();
        }
    }
}
