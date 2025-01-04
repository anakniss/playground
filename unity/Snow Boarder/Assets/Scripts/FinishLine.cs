using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem finishEffect;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            finishEffect.Play();
            Invoke("ReloadScene", loadDelay);
            GetComponent<AudioSource>().Play();
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
