using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationManager : MonoBehaviour
{
    public static CharacterAnimationManager Instance;

    public Transform idle;
    public Transform walk;
    public Transform jump;
    public Transform fall;
    public Transform death;

    public List<Transform> blueLenses;
    public List<Transform> redLenses;
    public List<Transform> yellowLenses;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowIdle()
    {
        if (idle.localScale == Vector3.one) return;
        Reset();
        idle.localScale = Vector3.one;
    }

    public void ShowWalk()
    {
        if (walk.localScale == Vector3.one) return;
        Reset();
        walk.localScale = Vector3.one;
    }

    public void ShowJump()
    {
        if (jump.localScale == Vector3.one) return;
        Reset();
        jump.localScale = Vector3.one;
    }

    public void ShowFall()
    {
        if (fall.localScale == Vector3.one) return;
        Reset();
        fall.localScale = Vector3.one;
    }

    public void ShowDeath()
    {
        if (death.localScale == Vector3.one) return;
        Reset();
        death.localScale = Vector3.one;
    }

    private void Reset()
    {
        idle.localScale = Vector3.zero;
        walk.localScale = Vector3.zero;
        jump.localScale = Vector3.zero;
        fall.localScale = Vector3.zero;
        death.localScale = Vector3.zero;
    }


    public void ShowBlueLens()
    {
        ResetLenses();
        foreach (Transform blueLens in blueLenses)
        {
            blueLens.localScale = Vector3.one;
        }
    }

    public void ShowRedLens()
    {
        ResetLenses();
        foreach (Transform redLens in redLenses)
        {
            redLens.localScale = Vector3.one;
        }
    }

    public void ShowYellowLens()
    {
        ResetLenses();
        foreach (Transform yellowLens in yellowLenses)
        {
            yellowLens.localScale = Vector3.one;
        }
    }

    void ResetLenses()
    {
        foreach (Transform blueLens in blueLenses)
        {
            blueLens.localScale = Vector3.zero;
        }
        foreach (Transform redLens in redLenses)
        {
            redLens.localScale = Vector3.zero;
        }
        foreach (Transform yellowLens in yellowLenses)
        {
            yellowLens.localScale = Vector3.zero;
        }
    }
}
