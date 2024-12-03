using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera thirdPersonCamera; // Referência para a câmera de terceira pessoa
    public Camera firstPersonCamera; // Referência para a câmera de primeira pessoa

    void Update()
    {
        // Alterna entre as câmeras quando a tecla Q é pressionada
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Alterna a ativação das câmeras
            if (thirdPersonCamera.enabled)
            {
                thirdPersonCamera.enabled = false;  // Desativa a câmera de terceira pessoa
                firstPersonCamera.enabled = true;   // Ativa a câmera de primeira pessoa
            }
            else
            {
                thirdPersonCamera.enabled = true;   // Ativa a câmera de terceira pessoa
                firstPersonCamera.enabled = false;  // Desativa a câmera de primeira pessoa
            }
        }
    }
}
