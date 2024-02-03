using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private GameObject Player;
    [SerializeField] private PlayerHealth playerhealth;
    [SerializeField] private LayerMask PlayerLayerMask;
    [Header("Enemy")]
    [SerializeField] private NavMeshAgent Agent;
    [SerializeField] private float attackRange;
    private bool InAttackRange;
    [SerializeField] Animator Anim;

    private void Awake(){
        Agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindWithTag("Player");
        playerhealth = Player.GetComponent<PlayerHealth>();
        Anim = GetComponent<Animator>();
    }

    private void Update(){
        Anim.SetBool("IsRunning",true);
        transform.LookAt(Player.transform);
        Agent.SetDestination(Player.transform.position);
        InAttackRange = Physics.CheckSphere(transform.position,attackRange,PlayerLayerMask);
        if(InAttackRange){Debug.Log("Attack"); SceneManager.LoadScene(1);}
    }
}
