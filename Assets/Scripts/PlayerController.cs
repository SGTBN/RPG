using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0 || y != 0)
        {
            Vector3 targetPos = transform.position + new Vector3(x, y);
            this.transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
        }
    }
}
