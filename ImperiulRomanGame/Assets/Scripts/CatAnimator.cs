using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CatAnimator : MonoBehaviour {

    private const string CAT_IS_WALKING = "CatIsWalking";
    private const string CAT_IS_SITTING = "CatIsSitting";

    [SerializeField] private Cat cat;
    private Animator animator;
    private void Awake() {
        animator = GetComponent<Animator>();
    }
    private void Update() {
        animator.SetBool(CAT_IS_WALKING, cat.IsWalking());
        animator.SetBool(CAT_IS_SITTING, cat.IsSitting());
    }
}
