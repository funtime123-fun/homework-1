using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    public Transform player; // Посилання на об'єкт Гравця
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Якщо гравець існує, постійно оновлюємо точку призначення
        if (player != null)
        {
            agent.SetDestination(player.position);
        }
    }
}