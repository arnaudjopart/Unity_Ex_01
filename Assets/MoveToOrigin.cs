using UnityEngine;

[SelectionBase]
public class MoveToOrigin : MonoBehaviour
{
    [SerializeField] private float m_speed=10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = -1*transform.position.normalized;
        transform.position += direction * m_speed * Time.deltaTime;
    }
}
