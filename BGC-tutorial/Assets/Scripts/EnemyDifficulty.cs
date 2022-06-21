using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDifficulty : MonoBehaviour
{
    public List<NavMeshAgent> navMeshAgents;
    public DifficultyController difficultyController;
    public float easySpeed;
    public float hardSpeed;

    // Start is called before the first frame update
    void Start()
    {
        if(difficultyController.difficulty == DifficultyController.Difficulty.easy)
        {
            foreach(NavMeshAgent agent in navMeshAgents)
            {
                agent.speed = easySpeed;
            }
        }
        else if(difficultyController.difficulty == DifficultyController.Difficulty.hard)
        {
            foreach(NavMeshAgent agent in navMeshAgents)
            {
                agent.speed = hardSpeed;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(difficultyController.difficulty == DifficultyController.Difficulty.easy)
        {
            foreach(NavMeshAgent agent in navMeshAgents)
            {
                agent.speed = easySpeed;
            }
        }
        else if(difficultyController.difficulty == DifficultyController.Difficulty.hard)
        {
            foreach(NavMeshAgent agent in navMeshAgents)
            {
                agent.speed = hardSpeed;
            }
        }
    }
}
