using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{

    public enum LASERSTATE
    {
        BEFORE_FIRE,
        WARNNING,
        AFTER_WARNNING,
        FIRE,
        FIRE_END
    }

    public GameObject laserBeamPrefab; // ������ �� ������
    public GameObject warningEffect; // ��� ȿ��
    public Transform spawnPoint; // �߻� ��ġ


    public float beamDelay = 1f; // ������ �� �߻� ����
    public float warningDelay = 2.0f;

    public float timer;

    public LASERSTATE laserstate = LASERSTATE.BEFORE_FIRE;

    //warningEffect �ν��Ͻ� -> 1���� -> laserBeamPrefab �ν��Ͻ�

    private void Start()
    {
        timer = 0f;
    }

    private void Update()
    {

        if (laserstate == LASERSTATE.BEFORE_FIRE)
        {
            timer += Time.deltaTime;

            if (timer >= warningDelay)
            {
                laserstate = LASERSTATE.WARNNING;
                timer = 0.0f;
            }
        }
        else if (laserstate == LASERSTATE.WARNNING)
        {
            ShowWarning();
            laserstate = LASERSTATE.AFTER_WARNNING;
        }
        else if (laserstate == LASERSTATE.AFTER_WARNNING)
        {
            timer += Time.deltaTime;

            if (timer >= beamDelay)
            {
                laserstate = LASERSTATE.FIRE;

            }
        }
        else if (laserstate == LASERSTATE.FIRE)
        {
            StartLaserBeam();

            laserstate = LASERSTATE.FIRE_END;
        }
        else if (laserstate == LASERSTATE.FIRE_END)
        {
            timer = 0.0f;
            laserstate = LASERSTATE.BEFORE_FIRE;
        }

    }

    private void ShowWarning()
    {
        StartCoroutine(CoShowWarning());

    }

    IEnumerator CoShowWarning()
    {

        GameObject temp = Instantiate(warningEffect, spawnPoint.position, spawnPoint.rotation);
        Destroy(temp, 0.2f);
        yield return new WaitForSeconds(0.3f);
        GameObject temp2 = Instantiate(warningEffect, spawnPoint.position, spawnPoint.rotation);
        Destroy(temp2, 0.2f);
        yield return new WaitForSeconds(0.3f);


    }

    private void StartLaserBeam()
    {
        GameObject temp = Instantiate(laserBeamPrefab, spawnPoint.position, spawnPoint.rotation);
        Destroy(temp, 0.5f);
    }
}
