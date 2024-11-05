using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    public float threshold;
    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            // Starting position of player
            transform.position = new Vector3(37.435f, 13.009f, 46.455f);
        }
    }
}
