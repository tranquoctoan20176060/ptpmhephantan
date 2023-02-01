using UnityEngine;

/// <summary>
/// Controls the behaviour of the player's gun.
/// </summary>
public class Gun : Weapon
{
    [Header("Firing")]
    public float CannonballSpeed = 500f;
    public Transform FirePoint;
    public GameObject MuzzleFlash;
    public GameObject CannonballPrefab;
    //PlayerHealthController PlayerHealthController;

    private PlayerMovementController playerMovementController;
    private Animator gunAnimator;
    private Animator muzzleFlashAnimator;

    /// <summary>
    /// Called by Unity when this GameObject starts.
    /// </summary>
    private void Start()
    {
        playerMovementController = GetComponentInParent<PlayerMovementController>();
        gunAnimator = GetComponent<Animator>();
        muzzleFlashAnimator = MuzzleFlash.GetComponent<Animator>();
        //PlayerHealthController = GetComponentInParent<PlayerHealthController>();
        //Debug.Log(PlayerHealthController);
    }

    /// <summary>
    /// Instantiates a projectile and sets it's velocity relative to the player's current direction.
    /// </summary>
    protected override void HandleAttack()
    {
        var cannonball3 = Instantiate(CannonballPrefab, FirePoint.position, Quaternion.identity);
        cannonball3.GetComponent<Cannonball>().Owner = playerMovementController.gameObject;
        cannonball3.GetComponent<Rigidbody2D>().velocity = new Vector2(playerMovementController.GetDirection() * CannonballSpeed, 0);
        //Debug.Log("attack");
        //Debug.Log(PlayerHealthController.damage);

        /*
        if (PlayerHealthController.damage >= 1 )
        {
            var cannonball = Instantiate(CannonballPrefab, FirePoint.position, Quaternion.identity);
            cannonball.GetComponent<Cannonball>().Owner = playerMovementController.gameObject;
            cannonball.GetComponent<Rigidbody2D>().velocity = new Vector2(playerMovementController.GetDirection() * CannonballSpeed, 0);
            Debug.Log(cannonball.gameObject.tag);
        }
        if(PlayerHealthController.damage >= 2 )
        {
            var cannonball1 = Instantiate(CannonballPrefab, FirePoint.position, Quaternion.identity);
            cannonball1.GetComponent<Cannonball>().Owner = playerMovementController.gameObject;
            cannonball1.GetComponent<Rigidbody2D>().velocity = new Vector2(playerMovementController.GetDirection() * CannonballSpeed, 0);
            Debug.Log(cannonball1.gameObject.tag);
        }
        if (PlayerHealthController.damage >= 3)
        {
            var cannonball2 = Instantiate(CannonballPrefab, FirePoint.position, Quaternion.identity);
            cannonball2.GetComponent<Cannonball>().Owner = playerMovementController.gameObject;
            cannonball2.GetComponent<Rigidbody2D>().velocity = new Vector2(playerMovementController.GetDirection() * CannonballSpeed, 0);
            Debug.Log(cannonball2.gameObject.tag);
        }*/


        // Create a cannonball, set it's owner and velocity.


        // Play the gun firing animations.
        gunAnimator.SetTrigger("Fire");
        muzzleFlashAnimator.SetTrigger("Fire");
    }
}
