using UnityEngine;

public class PlayerFactory : MonoBehaviour
{
    [SerializeField]
    GameObject objPlayer = null;

    public void Create()
    {
        Instantiate(objPlayer,this.transform);
        objPlayer = transform.GetChild(0).gameObject;
        objPlayer.GetComponent<ActorBase>().Init();
    }

    public GameObject GetObjPlayer()
    {
        return this.objPlayer;
    }
}
