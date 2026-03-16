using UnityEngine;
using UnityEngine.InputSystem;
public class AgentView : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public Vector2 Velocidad;

    InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         moveAction = InputSystem.actions.FindAction("Move");
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
         Velocidad = moveAction.ReadValue<Vector2>();
         animator.SetFloat("Velocidad",Velocidad);

        
    }
}
