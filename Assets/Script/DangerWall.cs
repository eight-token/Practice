using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour 
{
    void OnCollisionEnter (Collision hit)
    {
        if (hit.gameObject.CompareTag ("Player"))
        {
            SceneManager.LoadScene("unity");
        }
    }
}
