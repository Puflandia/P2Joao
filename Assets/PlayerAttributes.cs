using UnityEngine.AI;
using UnityEngine;

public enum PlayerMode { Normal, Fast, Stealthy }

public class PlayerAttributes : MonoBehaviour
{
    public PlayerMode playerMode;

    void Start()
    {
        SetPlayerMode();
    }

    void SetPlayerMode()
    {
        switch (playerMode)
        {
            case PlayerMode.Normal:
                
                break;
            case PlayerMode.Fast:
                
                GetComponent<NavMeshAgent>().speed = 10;
                break;
            case PlayerMode.Stealthy:
                
                GetComponent<NavMeshAgent>().speed = 2;
                GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0.5f);
                break;
        }
    }
}

