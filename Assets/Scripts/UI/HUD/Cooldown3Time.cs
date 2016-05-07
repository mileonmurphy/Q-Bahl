using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Cooldown3Time : MonoBehaviour
{

    GameObject player;

    PlayerTransform currForm;

    PlayerNormalForm normalForm;
    PlayerElementalForm elementalForm;
    PlayerWarpForm warpForm;
    PlayerRangedForm rangedForm;

    float cooldown3Normal;
    float cooldown3Ranged;
    float cooldown3Elemental;
    float cooldown3Warp;

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
            if (!player.GetComponent<PlayerNormalForm>().getCooling3())
            {
                GetComponent<Text>().text = normalForm.getCooling3Time() + "";
                cooldown3Normal = 0;
            }
            else
            {
                Invoke("cooldown3NormalStart", 0);
                GetComponent<Text>().text = System.Math.Round(normalForm.getCooling3Time() - cooldown3Normal, 2) + "";
                if (normalForm.getCooling3Time() - cooldown3Normal <= 0)
                {
                    cooldown3Normal = 0;
                }
            }
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[2])
        {
            GetComponent<Text>().text = warpForm.getCooling3Time() + "";
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[3])
        {
            GetComponent<Text>().text = rangedForm.getCooling3Time() + "";
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[4])
        {
            GetComponent<Text>().text = elementalForm.getCooling3Time() + "";
        }
    }

    void cooldown3NormalStart()
    {
        InvokeRepeating("cooldown3NormalIncrement", 0, 0.01f);
    }

    void cooldown3NormalIncrement()
    {
        cooldown3Normal += 0.01f;
    }
}
