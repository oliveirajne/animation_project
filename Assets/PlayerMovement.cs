using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 200f; // Velocidade do movimento
    public float rotationSpeed = 100f; // Velocidade de rotação
    private Animator animator;    // Referência para o Animator do personagem
    private Rigidbody rb;         // Referência para o Rigidbody do personagem

    void Start()
    {
        // Obtém o Animator e Rigidbody no início
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Obtém a entrada de movimento para frente (W) e rotação (A/D)
        float moveDirection = 0f;
        float rotationDirection = 0f;

        // Verifica se o personagem está se movendo para frente
        if (Input.GetKey(KeyCode.W)) // Move para frente
        {
            moveDirection = 10f;
        }

        // Verifica se o personagem deve rotacionar para a esquerda ou direita
        if (Input.GetKey(KeyCode.A)) // Rotaciona para a esquerda
        {
            rotationDirection = -5f;
        }
        else if (Input.GetKey(KeyCode.D)) // Rotaciona para a direita
        {
            rotationDirection = 5f;
        }

        // Aplica o movimento no Rigidbody (movimento simples)
        Vector3 movement = transform.forward * moveDirection * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

        // Aplica a rotação com base nas teclas A/D
        if (rotationDirection != 0)
        {
            transform.Rotate(0, rotationDirection * rotationSpeed * Time.deltaTime, 0);
        }

        // Atualiza a animação com base na movimentação
        animator.SetBool("isWalking", moveDirection != 0);
    }
}
