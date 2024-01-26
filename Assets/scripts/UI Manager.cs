using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public InputField velocityInput;
    public InputField deltaTimeInput;
    public InputField endDistanceInput;

    public void VelocityChanged()
    {

        float velocity = CubesGenerater.Instance.velocity;
        if (float.TryParse(velocityInput.text, out velocity))
        {
            CubesGenerater.Instance.velocity = velocity;
        }
    }
    public void DeltaTime()
    {
        float deltatime = CubesGenerater.Instance.deltaTime;
        if (float.TryParse(deltaTimeInput.text, out deltatime))
        {
            CubesGenerater.Instance.deltaTime = deltatime;
        }
    }

    public void EndDistance()
    {
        float endDistance = CubesGenerater.Instance.endDistance;
        if (float.TryParse(endDistanceInput.text, out endDistance))
        {
            CubesGenerater.Instance.endDistance = endDistance;
        }

    }
    private void Update()
    {
        if (velocityInput != null) { VelocityChanged(); }
        if (deltaTimeInput != null) { DeltaTime(); }
        if (endDistanceInput != null) { EndDistance(); }
    }
}
