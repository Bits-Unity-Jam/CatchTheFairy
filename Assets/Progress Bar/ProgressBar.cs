using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    //[SerializeField] private ParticleSystem particleSys;
    //public float targetProgress = 0;
    public float fillSpeed = 0.67f;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < FaityCounter.counter)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
    }
    //public void IncrementProgres()
    //{
    //    targetProgress = slider.value + 1;
    //}
}

