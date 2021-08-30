using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsNeededToWin;
    private int objectsCollected;
    [SerializeField] private bool onTrigger;
    [SerializeField] private bool onCollision;
    [SerializeField] private TextMeshProUGUI tmpObjectiveText;
    [SerializeField] private string nextLevelToLoad;
    private int totalToCollect;
    [SerializeField] ParticleSystem particleSystemForObjects;
    private void Awake()
    {
        objectsCollected = 0;
        totalToCollect = 0;
        totalToCollect = objectsNeededToWin.Count;
    }

    // Start is called before the first frame update
    void Start()
    {
        tmpObjectiveText.text = "Items to Collect: " + totalToCollect;

        foreach (var item in objectsNeededToWin)
        {
            Instantiate(particleSystemForObjects, item.transform.position, Quaternion.identity, item.transform);
        }
    }

    bool CheckIfWon()
    {
        if (objectsCollected == totalToCollect)
        {
            Debug.Log("HAS WON");
            tmpObjectiveText.text = "All items collected!";
            AudioManager.instance.PlaySounds("WIN");
            MainManager.instance.GetPlayer().GetComponent<PlayerController>().PlayWinParticleEffect();
            LeanTween.delayedCall(AudioManager.instance.GetSound("WIN").clip.length, () => {
                FindObjectOfType<FadeCamera>().RedoFade("FadeOut");
                LeanTween.delayedCall(2f, () => {
                    SceneManager.LoadScene(nextLevelToLoad);
                }); 
            });
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (onCollision)
        {
            foreach (var item in objectsNeededToWin)
            {
                if (item.gameObject == collision.gameObject)
                {
                    objectsCollected++;
                    objectsNeededToWin.Remove(item);
                    tmpObjectiveText.text = "Items to Collect: " + (totalToCollect - objectsCollected);
                    if (CheckIfWon())
                    {
                        break;
                    }
                }
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (onTrigger)
        {
            foreach (var item in objectsNeededToWin)
            {
                if (item.gameObject == other.gameObject)
                {
                    objectsCollected++;
                    objectsNeededToWin.Remove(item);
                    tmpObjectiveText.text = "Items to Collect: " + (totalToCollect - objectsCollected);
                    if (CheckIfWon())
                    {
                        break;
                    }
                }
            }
        }
    }
}
