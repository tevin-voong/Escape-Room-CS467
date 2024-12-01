using UnityEngine;

public class Arrow : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Target"))
		{	
			print("hit" + collision.gameObject.name + " !");
			Destroy(gameObject);
		}
	} 
}
