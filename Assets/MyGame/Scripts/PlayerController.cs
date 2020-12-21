using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public GameObject player;

    private float moveHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal") * speed;
        moveHorizontal = moveHorizontal * Time.deltaTime;

        player.GetComponent<Transform>().position = player.GetComponent<Transform>().position + new Vector3(moveHorizontal, 0, 0);
       
    }
}
