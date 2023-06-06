using UnityEngine;

public class ObjectsMoving : MonoBehaviour
{
    [SerializeField] private float speed = 4.5f;
    

    private void Update()
    {
       transform.Translate(Vector3.right * speed);
    }
}
