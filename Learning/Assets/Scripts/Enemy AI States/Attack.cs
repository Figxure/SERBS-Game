//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class Attack : BaseState
//{
//    float Rotationspeed = 4f;
//    AudioSource punch;

//    public Attack(GameObject _npc, NavMeshAgent _agent, Transform _player)
//            : base(_npc, _agent, _player)
//    {
//        name = STATE.ATTACK;

//        punch = _npc.GetComponent<AudioSource>();
//    }

//    public override void Enter()
//    {
//        //agent.isStopped = true;

//        punch.Play();


//        base.Enter();
//    }

//    public override void Update()
//    {
//        Vector3 direction = player.position - npc.transform.position;
//        float angle = Vector3.Angle(direction, npc.transform.forward);

//        direction.y = 0;

//        npc.transform.rotation = Quaternion.Slerp(npc.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * Rotationspeed);

//        if(!CanAttackPlayer())
//        {
//            NextState = new Chase(npc, agent, player);
//            stage = Event.EXIT;
//        }
//    }


//    public override void Exit()
//    {
//        punch.Stop();
//        base.Exit();
//    }
//}
