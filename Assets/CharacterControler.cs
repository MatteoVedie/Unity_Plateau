using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CustomCharacterController : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    private NavMeshAgent _agent;
    private Animator _animation;
    private float _idleTimer; // Pour gérer les animations d'attente
    private Rigidbody _rigidbody;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(_target.transform.position);
        _animation = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_agent != null && _animation != null)
        {
            // Synchronise la vitesse avec l'Animator
            _animation.SetFloat("Speed", _agent.velocity.magnitude);

            // Gérer les animations Idle aléatoires
            if (_agent.velocity.magnitude < 0.1f) // Si le personnage est immobile
            {
                _idleTimer += Time.deltaTime;

                if (_idleTimer > 3f) // Toutes les 3 secondes
                {
                    int randomIdle = Random.Range(0, 3); // Valeur aléatoire : 0, 1 ou 2
                    _animation.SetInteger("IdleRandom", randomIdle);
                    _idleTimer = 0; // Réinitialisation du timer

                    
                }
            }
        }
    }
}
