using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
   private Player player=>GetComponent<Player>();
   private Animator anim => GetComponent<Animator>();

   private void Update()
   {
      anim.SetBool("IsGround",player.isGround);
      anim.SetBool("IsJump",player.isJump);
   }
}
