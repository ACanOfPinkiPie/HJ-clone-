using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PrpgressLine : MonoBehaviour
{
    public Player Player;
    public Transform Finish;
    public Slider Slider;
    public float AcceptableFinishPlayerDistance = 1f;




    private float _minReachedY;
    private float _startY;

    void Start()
    {
        _startY = Player.transform.position.y;

    }

    void Update()
    {
        _minReachedY = Mathf.Min(_minReachedY, Player.transform.position.y);
       
        float finishY = Finish.position.y;
        float t = Mathf.InverseLerp(_startY, finishY + AcceptableFinishPlayerDistance, _minReachedY);
        Slider.value = t;

    }
}
