using UnityEngine;

public class SniperEnemy : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;

    private bool playerIn = false;
    private Transform playerTransform = null;


    // Update is called once per frame
    void Update()
    {
        if (playerIn && playerTransform != null)
        {
            Vector2 dir = playerTransform.position - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.LookAt(playerTransform);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTransform = other.transform;
            playerIn = true;
            Debug.Log("player is in the range");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTransform = other.transform;
            playerIn = false;
            Debug.Log("player has exited the range");
        }
    }
}
