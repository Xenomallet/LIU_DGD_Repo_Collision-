using UnityEngine;
using UnityEngine.InputSystem;

public class move_cube : MonoBehaviour
{
    //Declaring variables
    public Rigidbody2D rb;
    public float movespeed;
    private Vector2 movedirection;
    public InputActionReference move;
    public GameManager GM;
    private SpriteRenderer color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Add ridgidbody to object
        rb = GetComponent<Rigidbody2D>();

        //Set color to object's SpriteRenderer
        color = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       //Add direction of movement with input manager
       movedirection = move.action.ReadValue<Vector2>(); 
    }

    // FixedUpdate is called once per physics frame
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x:movedirection.x * movespeed, y:movedirection.y * movespeed);
    }

    //On collision change color
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Console notifies you if you hit something
        Debug.Log("HIT");

        //Changes the color when hitting something
        color.color = Random.ColorHSV();
    }

    //Destroy collectable on trigger enter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy anything you touch
        Destroy(collision.gameObject);

        //Respawn object on collision
        GM.Respawn();
    }

}
