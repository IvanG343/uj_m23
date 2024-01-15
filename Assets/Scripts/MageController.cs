using UnityEngine;

public class MageController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject[] weapons;
    private int currentWeaponId = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetTrigger("Idle");
            Debug.Log("Key 1 Pressed");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetTrigger("Walk");
            Debug.Log("Key 2 Pressed");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.SetTrigger("Jump");
            Debug.Log("Key 3 Pressed");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            animator.SetTrigger("Heal");
            Debug.Log("Key 4 Pressed");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            animator.SetTrigger("Attack");
            Debug.Log("Key 5 Pressed");
        }

        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            currentWeaponId++;
            if(currentWeaponId > weapons.Length -1)
                currentWeaponId = 0;
            ChangeWeapon();
            //Debug.Log("Wheel value: " + Input.GetAxis("Mouse ScrollWheel"));
        } else if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            currentWeaponId--;
            if (currentWeaponId < 0)
                currentWeaponId = weapons.Length -1;
            ChangeWeapon();
            //Debug.Log("Wheel value" + Input.GetAxis("Mouse ScrollWheel"));
        }
        //Debug.Log("Weapon ID " + currentWeaponId);
    }

    private void ChangeWeapon()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(i != currentWeaponId)
                weapons[i].SetActive(false);
            else
                weapons[i].SetActive(true);
        }
    }
}
