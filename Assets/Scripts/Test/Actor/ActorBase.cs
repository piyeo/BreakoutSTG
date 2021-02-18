using UnityEngine;

public class ActorBase : MonoBehaviour
{
    private GameObject Obj;
    private Transform Trans;
    private bool IsActive = false;

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

    public Vector3 GetPosition()
    {
        return this.Trans.position;
    }

    public void AddPosition(float _x, float _y)
    {
        this.Trans.position += new Vector3(_x, _y, 0f);
    }
}
