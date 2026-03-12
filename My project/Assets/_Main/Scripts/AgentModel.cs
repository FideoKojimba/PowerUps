using Unity.VisualScripting;
using UnityEngine;

public class AgentModel : MonoBehaviour
{
    [SerializeField] private AgentController _agentController;
    [SerializeField] private float _velocidad = 20f;
    [SerializeField] private Rigidbody _rb;
    
    public void Movimiento()
    {
        _rb.linearVelocity = new Vector3(_agentController.moveValue.x, _rb.linearVelocity.y, _agentController.moveValue.y); 
    }
   
    void Update()
    {
        Movimiento(); 
    }
}
