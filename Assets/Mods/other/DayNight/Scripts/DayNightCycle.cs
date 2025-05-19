using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light sunLight;
    public Gradient directionalColor;
    public AnimationCurve intensityCurve;
    public float cycleDuration = 300f;

    private float cycleTimes;

    void Start()
    {
        if (!sunLight) sunLight = GetComponentInChildren<Light>();
    }

    void Update()
    {
        cycleTimes += Time.deltaTime;
        float t = (cycleTimes % cycleDuration) / cycleDuration;

        float sunAngle = t * 360f - 90f;
        sunLight.transform.rotation = Quaternion.Euler(sunAngle, 170, 0);

        sunLight.color = directionalColor.Evaluate(t);
        sunLight.intensity = intensityCurve.Evaluate(t);
    }
}
