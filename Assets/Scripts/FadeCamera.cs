using UnityEngine;

public class FadeCamera : MonoBehaviour
{
    public AnimationCurve FadeInCurve = new AnimationCurve(new Keyframe(0, 1), new Keyframe(0.6f, 0.7f, -1.8f, -1.2f), new Keyframe(1, 0));
    public AnimationCurve FadeOutCurve = new AnimationCurve(new Keyframe(0, 1), new Keyframe(0.6f, 0.7f, -1.8f, -1.2f), new Keyframe(1, 0));
    public float timeMult;
    private float _alpha = 1;
    private Texture2D _texture;
    private bool _done;
    private float _time;

    private string _fadeString;

    private void Awake()
    {
        _fadeString = "FadeIn";
    }

    public void Reset()
    {
        _done = false;
        switch (_fadeString)
        {
            case "FadeIn":
                _alpha = 1;
                break;
            case "FadeOut":
                _alpha = 0;
                break;
            default:
                break;
        }
        _time = 0;
    }

    [RuntimeInitializeOnLoadMethod]
    public void RedoFade(string name)
    {
        _fadeString = name;
        Reset();
    }

    public void OnGUI()
    {
        if (_done) return;
        if (_texture == null) _texture = new Texture2D(1, 1);

        _texture.SetPixel(0, 0, new Color(0, 0, 0, _alpha));
        _texture.Apply();

        _time += timeMult * Time.deltaTime;
        switch (_fadeString)
        {
            case "FadeIn":
                _alpha = FadeInCurve.Evaluate(_time);
                break;
            case "FadeOut":
                _alpha = FadeOutCurve.Evaluate(_time);
                break;
            default:
                break;
        }
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _texture);

        switch (_fadeString)
        {
            case "FadeIn":
                if (_alpha <= 0) _done = true;
                break;
            case "FadeOut":
                if (_alpha >= 1) _done = true;
                break;
            default:
                break;
        }   
    }
}