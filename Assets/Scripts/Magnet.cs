using UnityEngine;

public class Magnet : Powerup
{
    protected override void Activate()
    {
        //base.Activate();

        GameManager.Instance.ActivateManget();
    }
}
