using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MascotAnimSelector : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private int howManyAnimsWeTalkingAboutHereBud;
    private string animFloatName = "YouComeIntoMyHouse";
    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(0, howManyAnimsWeTalkingAboutHereBud+1);
        anim.SetFloat(animFloatName, num);
    }
}
