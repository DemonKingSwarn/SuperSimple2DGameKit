using UnityEngine;
using TMPro;
 
public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI display_Text;
 
    private void Start() 
    {
        InvokeRepeating("GetFPS", 1, 1);
    }

    public void GetFPS ()
    {
        int fps = (int)(1f / Time.unscaledDeltaTime);
        display_Text.text = fps + " FPS";
    }
}