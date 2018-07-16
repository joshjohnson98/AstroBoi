using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public float fuelLossRate;
    public float oxygenLossRate;

    LoadScene loadScene;
    public PlayerControls player;
    private float OxygenHitPoint = 10000;
    private float FuelHitPoint = 10000; 
    private float maxHitpoint = 10000;

    public GameObject OxygenBar;
    public GameObject FuelBar; 
    // Use this for initialization
    void Start()
    {
        UpdateOxygenBar();
        UpdateFuelBar();
        loadScene = gameObject.GetComponent<LoadScene>();
    }

    private void Update()
    {
        if(OxygenHitPoint<=0){
            player.isDead = true;
            loadScene.LoadByIndex(2);
        }

        UseOxygen();  

        if (Input.GetKey(KeyCode.Space))
        {
            UseFuel();
        }
    }

    public float getFuelHP(){
        return FuelHitPoint;
    }

    private void UpdateFuelBar()
    {
        float ratio = FuelHitPoint / maxHitpoint;
        FuelBar.GetComponent<RectTransform>().localScale = new Vector3(ratio, 1, 1);
    }

    private void UpdateOxygenBar()
    {
        float ratio = OxygenHitPoint / maxHitpoint;
        OxygenBar.GetComponent<RectTransform>().localScale = new Vector3(ratio, 1, 1);
    }

    public void UseFuel()
    {
        FuelHitPoint -= fuelLossRate;
        if (FuelHitPoint < 0)
        {
            FuelHitPoint = 0;
            Debug.Log("Dead Boi!!!");
        }
        UpdateFuelBar();
    }

    public void UseOxygen()
    {
        OxygenHitPoint -= oxygenLossRate;
        if (OxygenHitPoint < 0)
        {
            OxygenHitPoint = 0;
            Debug.Log("Dead Boi!!!");
        }
        UpdateOxygenBar();
    }

    public void IncreaseFuel(float increaseFuelBy)
    {
        FuelHitPoint += increaseFuelBy;
        if (FuelHitPoint > maxHitpoint)
        {
            FuelHitPoint = maxHitpoint;
        }
        UpdateFuelBar();

    }

    public void IncreaseOxygen(float increaseOxygenBy)
    {
        OxygenHitPoint += increaseOxygenBy;
        if (OxygenHitPoint > maxHitpoint)
        {
            OxygenHitPoint = maxHitpoint;
        }
        UpdateOxygenBar();

    }

}