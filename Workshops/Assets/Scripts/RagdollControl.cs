using UnityEngine;

public class RagdollControl : MonoBehaviour
{
    public Animator animator;
    public Rigidbody[] allRigidbodies;

    private void Awake()
    {
        allRigidbodies = GetComponentsInChildren<Rigidbody>();
        for (int i = 0; i < allRigidbodies.Length; i++)
        {
            Debug.Log(i);
            allRigidbodies[i].isKinematic = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            MakePhysics();
        }
    }

    public void MakePhysics()
    {
        animator.enabled = false;
        for (int i = 0; i < allRigidbodies.Length - 1; i++)
        {
            allRigidbodies[i].isKinematic = false;
        }
    }
}
