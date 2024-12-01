using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class Weapons : MonoBehaviour
{

    public GameObject arrowPrefab;
    public Transform arrowSpawn;
    public float arrowVelocity = 30;
    public float arrowPrefabLifeTime = 3f;

    // Update is called once per frame
    void Update()
    {
        // Left mouse click
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireWeapon();
        }
    }

    private void FireWeapon()
    {
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawn.position, Quaternion.identity);

        // Where arrow is being shot from and shooting the arrow
        arrow.GetComponent<Rigidbody>().AddForce(arrowSpawn.forward.normalized * arrowVelocity, ForceMode.Impulse);

        // Arrow destroyed/erased
        StartCoroutine(DestroyArrowAfterTime(arrow, arrowPrefabLifeTime));
    }

    private IEnumerator DestroyArrowAfterTime(GameObject arrow, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(arrow);
    }
}
