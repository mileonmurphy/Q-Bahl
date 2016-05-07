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
                GetComponent<Text>().text = "Ready";
                cooldown3Normal = 0;
            }
            else
            {
                Invoke("cooldown3NormalStart", 0);
                GetComponent<Text>().text = "Cooling";
                if (normalForm.getCooling3Time() - cooldown3Normal <= 0)
                {
                    cooldown3Normal = 0;
                }
            }
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[2])
        {
            if (!player.GetComponent<PlayerWarpForm>().getCooling3())
            {
                GetComponent<Text>().text = "Ready";
                cooldown3Warp = 0;
            }
            else
            {
                Invoke("cooldown3WarpStart", 0);
                GetComponent<Text>().text = "Cooling";
                if (warpForm.getCooling3Time() - cooldown3Warp <= 0)
                {
                    cooldown3Warp = 0;
                    CancelInvoke("cooldown3WarpIncrement");
                }
            }
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[3])
        {
            if (!player.GetComponent<PlayerRangedForm>().getCooling3())
            {
                GetComponent<Text>().text = "Ready";
                cooldown3Ranged = 0;
            }
            else
            {
                Invoke("cooldown3RangedStart", 0);
                GetComponent<Text>().text = "Cooling";
                if (rangedForm.getCooling3Time() - cooldown3Ranged <= 0)
                {
                    cooldown3Ranged = 0;
                }
            }
        }

        if (currForm == player.GetComponent<PlayerTransformManager>().transform_dict[4])
        {
            if (!player.GetComponent<PlayerElementalForm>().getCooling3())
            {
                GetComponent<Text>().text = "Ready";
                cooldown3Elemental = 0;
            }
            else
            {
                Invoke("cooldown3ElementalStart", 0);
                GetComponent<Text>().text = "Cooling";
                if (elementalForm.getCooling3Time() - cooldown3Elemental <= 0)
                {
                    cooldown3Elemental = 0;
                    CancelInvoke("cooldown3ElementalIncrement");
                }
            }
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

    void cooldown3WarpStart()
    {
        InvokeRepeating("cooldown3WarpIncrement", 0, 0.01f);
    }

    void cooldown3WarpIncrement()
    {
        cooldown3Warp += 0.01f;
    }

    void cooldown3ElementalStart()
    {
        InvokeRepeating("cooldown3ElementalIncrement", 0, 0.01f);
    }

    void cooldown3ElementalIncrement()
    {
        cooldown3Elemental += 0.01f;
    }

    void cooldown3RangedStart()
    {
        InvokeRepeating("cooldown3RangedIncrement", 0, 0.01f);
    }

    void cooldown3RangedIncrement()
    {
        cooldown3Ranged += 0.01f;
    }
}
