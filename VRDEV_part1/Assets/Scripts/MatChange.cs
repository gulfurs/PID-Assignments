using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatChange : MonoBehaviour
{

    public Material materialOnHit;
    public MeshRenderer bucketRenderer;

    void Start()
    {
        bucketRenderer = GetComponent<MeshRenderer>();

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            ChangeBucketMaterial();

        }
    }

    void ChangeBucketMaterial()
    {
        bucketRenderer.material = materialOnHit;

        Debug.Log("test");
    }

}
