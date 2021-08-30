using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInLevelTitle : MonoBehaviour
{
    public CanvasGroup _canvasGroup;
    public GameObject _textObject;
    public float _num;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(_textObject, _num, 1f).setOnStart(() => {
            LeanTween.alphaCanvas(_canvasGroup, 1, 1f).setOnComplete(() => {
                LeanTween.delayedCall(1f, () => {
                    LeanTween.alphaCanvas(_canvasGroup, 0, 1f).setOnComplete(() => {
                        Destroy(gameObject);
                    });
                });
            });
        });
    }
}
