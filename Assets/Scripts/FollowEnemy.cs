using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public Transform player;
    public float attackDistance = 3;
    public float speed = 2;
    

    private void Update()
    {
        var distance = Vector3.Distance(transform.position, player.position);
        if (distance < attackDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
}
