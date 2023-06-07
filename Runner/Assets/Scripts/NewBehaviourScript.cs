using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float Background = 2f;
    
    private void Update()
    {
       transform.position -= new Vector3 (Background * Time.deltaTime, 0,0);
    }
}
