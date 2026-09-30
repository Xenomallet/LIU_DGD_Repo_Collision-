using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Add variables
    public GameObject collectable;

    //Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Respawn();
    }

    //Update is called once per frame
    void Update()
    {
        
    }

    //Make function that spawns collectable
    public void Respawn()
    {
        //Spawn collectable at random location
        Instantiate(collectable, new Vector2(Random.Range(-10f, 10f), Random.Range(-5f, 5f)), collectable.transform.rotation);
    }
}
