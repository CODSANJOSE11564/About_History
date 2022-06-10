using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
   [SerializeField] private GameObject WinnerCanvas = default;
   public void Youlost()
   {
      WinnerCanvas.SetActive(true);
   }

   public void ChangeScene()
   {
      SceneManager.LoadScene(0);
   }
}
