using UnityEngine;

public class SniperEnemy : MonoBehaviour
{
    public Transform playerTransform;
    public float speed = 10.0f;
    private bool playerIn = false;


    // Update is called once per frame
    void Update()
    {
        if (playerIn)
        {
            Vector2 dir   = playerTransform.position - transform.position;
            float   angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
            transform.LookAt(playerTransform);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIn = true;
            Debug.Log("player is in the range");
        }
    }

      private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIn = false;
            Debug.Log("player has exited the range");
        }
    }
}
