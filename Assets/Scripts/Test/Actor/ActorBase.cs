using UnityEngine;

public sealed class ActorBase : MonoBehaviour
{
    private GameObject Obj;
    private Transform Trans;
    private bool IsActive;

    public void Init()
    {
        this.Obj = this.gameObject;
        this.Trans = this.transform;
        this.SetActive(false);
    }

    public void WakeUp(Vector3 _position)
    {
        this.SetPosition(_position);
        this.SetActive(true);
    }

    public void SetActive(bool _isActive)
    {
        this.Obj.SetActive(_isActive);
        this.IsActive = _isActive;
    }
    public void SetPosition(Vector3 _vector3)
    {
        this.Trans.position = _vector3;
    }
    public void AddPosition(Vector3 _vector3)
    {
        this.Trans.position += _vector3;
    }
}
