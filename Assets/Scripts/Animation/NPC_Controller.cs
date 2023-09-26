using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Controller : MonoBehaviour
{
    [SerializeField] private Animator animator;
    //[SerializeField] private int HP = 2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ruy");
            Dead();

          
        }
    }
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) 
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.K)) 
        {
            Dead();

        }
         
    }
    private void Attack()
    {
        animator.SetTrigger("attack");
    }
    private void Dead ()
    {
        animator.SetBool("dead",true);
        Destroy(gameObject, 2);
    }
  
}
