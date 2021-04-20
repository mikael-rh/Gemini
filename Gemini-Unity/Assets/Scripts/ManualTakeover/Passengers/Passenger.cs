using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Passenger : MonoBehaviour {
    private const float 
        ANIM_SPEED = 0.6f,
        MIN_ANIM_SPEED = 0.25f,
        SPEED_THRESHOLD = 0.15f;

    [HideInInspector]
    public UnityEvent OnDestinationReached;
    public NavMeshAgent agent { get; private set; }

    private bool idle;

    public bool ReachedDestination => agent == null || (agent.enabled && agent.remainingDistance <= agent.stoppingDistance);

    private void Start() {
        agent = GetComponentInChildren<NavMeshAgent>();
        agent.updateRotation = true;
        agent.updatePosition = true;
    }

    public void SetDestination(Vector3 destination) {
        if (agent == null) agent = GetComponentInChildren<NavMeshAgent>();
        agent.SetDestination(destination);
    }

    private void Update() {
        if (!idle && ReachedDestination) {
            OnDestinationReached?.Invoke();
        }
    }

    private void LateUpdate() {
        idle = ReachedDestination;
    }

    void OnDrawGizmos() {
        if (agent == null) return;

        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(agent.destination, 0.25f);
    }
}
