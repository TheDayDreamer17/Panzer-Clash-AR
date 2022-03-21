using UnityEngine;

public class TrailSphere : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
        Disable();
    }

    public void Enable()
    {
        _meshRenderer.enabled = true;
    }
    public void Disable()
    {
        _meshRenderer.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameEvents.OnSurfaceFound?.Invoke(this);
    }
}
