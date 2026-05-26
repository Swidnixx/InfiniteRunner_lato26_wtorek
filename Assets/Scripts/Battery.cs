using UnityEngine;

public class Battery : Powerup
{
    protected override void Activate()
    {
        //base.Activate();
        GameManager.Instance.ActivateBattery();
    }
}
