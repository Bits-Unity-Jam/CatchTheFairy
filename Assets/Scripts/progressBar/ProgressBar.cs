using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private ParticleSystem particleSys;
    //public float targetProgress = 0;
    public float fillSpeed = 0.67f;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("progresBarParticle").GetComponent<ParticleSystem>();
    }
    // Start is called before the first frame update
    void Start()
    {
        particleSys.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < FaityCounter.counter)
        {
            slider.value += fillSpeed * Time.deltaTime;
            if (!particleSys.isPlaying)
            {
                particleSys.Play();
            }
        }
        else
        {
            particleSys.Stop();
        }
    }
    //public void IncrementProgres()
    //{
    //    targetProgress = slider.value + 1;
    //}
}

