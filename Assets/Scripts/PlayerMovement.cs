using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    private PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation.Normalize();
        Move();
    }

    public void Move()
    {
        if (view.IsMine)
        {
            int speed = 5;

            if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A))
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.Space))
                transform.Translate(Vector2.up * speed * 2 * Time.deltaTime);
           }

    }
        
}

