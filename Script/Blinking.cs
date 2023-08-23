using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    public Light Lamp;
    public float Timer;
    bool lampOn;
    bool lampBlink;
    public float TimeOn;

    // Start is called before the first frame update
    void Start()
    {
        bool lampOn = false;
        bool lampBlink = false;
        StartCoroutine(blinking(lampBlink));
    }

    // Update is called once per frame
    void Update()
    {
        float timeOn = 0.1f;
        float TimeOff = 0.5f;
        var changeTime = 0;
        if (lampBlink == true)
        {
            if (Time.time > changeTime)
            {
                Lamp.enabled = !Lamp.enabled;
                if (Lamp.enabled)
                    changeTime = (int)(Time.time + TimeOn);
                else
                    changeTime = (int)(Time.time + TimeOff);
            }
        }
        else
             Lamp.enabled = false;
    }


    void lampCheck(bool lampBlink)
    {
        if (lampOn == false)
            lampBlink = true;
        else
            lampBlink = false;

    }
    IEnumerator blinking(bool lampBlink)
    {
        lampCheck(lampBlink);
        if (lampBlink == true)
        {
            WaitForSeconds wait = new WaitForSeconds(15);
            for (int i = 0; i < 10; i++)
            {
                yield return wait;
            }
        }
        else
            yield return null;

    }
}
