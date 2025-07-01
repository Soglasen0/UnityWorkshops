using UnityEngine;

public class StopPhysics : MonoBehaviour
{
    public Collider sphere;
    public Collider finish;

    private void OnTriggerEnter(Collider other)
    {
        sphere.GetComponent<Rigidbody>().isKinematic = true;
    }
}
