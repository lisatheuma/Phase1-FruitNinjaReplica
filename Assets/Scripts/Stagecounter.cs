using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Stagecounter : MonoBehaviour
{
    SpriteRenderer _stageCounterFill;
    public Image stageCounterFill;
    private Animation anim;

    bool _counterFillAnim;
    private GameObject _sushiPrefab;

    private Text stageCount;
    public static int stageamount = 0;

    [SerializeField]    
    private float currentSpeed;

    void Start(){
        stageCount = GetComponent<Text>();
        anim = gameObject.GetComponent<Animation>();
        _counterFillAnim = false;
        
    }

    void Update()
    {
        stageCount.text =  stageamount.ToString();;

        if(stageCounterFill.fillAmount != 1f)
        {
            stageCounterFill.fillAmount += 0.01f;
        }
        

        //if(slicing sushi)
        {
            //fill
            //fill x2 on combo
            //speed increases over time
        }

        if(stageCounterFill.fillAmount == 1f)
        {
            //anim.Play("CounterFillAnim");
            stageamount = stageamount + 1;
            //waitforseconds
            stageCounterFill.fillAmount -= 1f;
        }

        //when collecting 2X powerup
        //SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        //renderer.color = Color.;
    }

}
