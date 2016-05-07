using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FormSymbolPicker : MonoBehaviour {

    PlayerTransform pt;
    public Dictionary<int, PlayerTransform> dic;
    public Sprite curr;
    public Sprite normalForm;
    public Sprite elementalForm;
    public Sprite warpForm;
    public Sprite rangedForm;

	// Use this for initialization
	void Start () {
        pt = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerTransformManager>().current_form;
        dic = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerTransformManager>().transform_dict;
	}
	
	// Update is called once per frame
	void Update () {
        pt = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerTransformManager>().current_form;

        if (pt == dic[1])
        {
            GetComponent<Image>().sprite = normalForm;
            curr = normalForm;
        }

        if (pt == dic[2])
        {
            GetComponent<Image>().sprite = warpForm;
            curr = warpForm;
        }

        if (pt == dic[3])
        {
            GetComponent<Image>().sprite = rangedForm;
            curr = rangedForm;
        }

        if (pt == dic[4])
        {
            GetComponent<Image>().sprite = elementalForm;
            curr = elementalForm;
        }
	}
}
