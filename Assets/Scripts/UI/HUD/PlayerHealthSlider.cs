using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealthSlider : MonoBehaviour {

    Slider slide;
    PlayerHealth ph;

	// Use this for initialization
	void Start () {
        slide = GetComponent<Slider>();
        ph = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        slide.maxValue = ph.startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
        slide.value = ph.currentHealth;
	}
}
