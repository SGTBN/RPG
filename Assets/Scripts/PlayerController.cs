using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        animator.SetFloat("xWalk", x);
        animator.SetFloat("yWalk", y);

        if (x != 0 || y != 0)
        {
            Vector3 targetPos = transform.position + new Vector3(x, y);
            this.transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);
        }
    }
}
