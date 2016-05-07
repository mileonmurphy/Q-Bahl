using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Cooldown2Time : MonoBehaviour
{

    GameObject player;

    PlayerTransform currForm;

    PlayerNormalForm normalForm;
    PlayerElementalForm elementalForm;
    PlayerWarpForm warpForm;
    PlayerRangedForm rangedForm;

    float cooldown2Normal;
    float cooldown2Ranged;
    float cooldown2Elemental;
    float cooldown2Warp;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        normalForm = player.GetComponent<PlayerNormalForm>();
        elementalForm = player.GetComponent<PlayerElementalForm>();
        warpForm = player.GetComponent<PlayerWarpForm>();
        rangedForm = player.GetComponent<PlayerRangedForm>();
    }

    // Update is called once per frame
    void Update()
    {
        currForm = player.GetComponent<PlayerTransformManager>().current_form;

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[1])
        {
            if (!player.GetComponent<PlayerNormalForm>().getCooling2())
            {
                GetComponent<Text>().text = normalForm.getCooling2Time() + "";
                cooldown2Normal = 0;
            }
            else
            {
                Invoke("cooldown2NormalStart", 0);
                GetComponent<Text>().text = System.Math.Round(normalForm.getCooling2Time() - cooldown2Normal, 2) + "";
                if (normalForm.getCooling2Time() - cooldown2Normal <= 0)
                {
                    cooldown2Normal = 0;
                }
            }
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[2])
        {
            GetComponent<Text>().text = warpForm.getCooling2Time() + "";
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[3])
        {
            GetComponent<Text>().text = rangedForm.getCooling2Time() + "";
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[4])
        {
            GetComponent<Text>().text = elementalForm.getCooling2Time() + "";
        }
    }
    void cooldown2NormalStart()
    {
        InvokeRepeating("cooldown2NormalIncrement", 0, 0.01f);
    }

    void cooldown2NormalIncrement()
    {
        cooldown2Normal += 0.01f;
    }

}
