//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public abstract class BaseState : MonoBehaviour
//{
//    public enum STATE
//    {     IDLE, CHASE, ATTACK, PATROL    };

//    public enum Event
//    {   ENTER, UPDATE, EXIT   };

//    public STATE name;
//    protected Event stage;
//    protected GameObject npc;
//    protected Transform player;
//    protected BaseState NextState;
//    protected NavMeshAgent agent;

//    float VisDist = 10.0f;
//    float VisAngle = 35.0f;
//    float punchDist = 1f;

//    public BaseState ( GameObject _npc, NavMeshAgent _agent, Transform _player)
//    {
//        npc = _npc;
//        agent = _agent;
//        stage = Event.ENTER;
//        player = _player;
//    }

//    public virtual void Enter()
//    {
//        stage = Event.ENTER;
//    }


//    public virtual void Update()
//    {
//        NextState = new Chase(npc, agent, player);
//        stage = Event.EXIT;

//    }

//    public virtual void FixedUpdate()
//    {
//        //Process();
//    }

//    public virtual void Exit()
//    {
//        stage = Event.EXIT;
//    }

//    public BaseState Process()
//    {
//        if(stage == Event.ENTER)
//        {
//            Enter();
//        }

//        if (stage == Event.UPDATE)
//        {
//            Update();
//        }

//        if (stage == Event.EXIT)
//        {
//            Exit();
//            return NextState;
//        }
//        return this;
//    }

//    public bool Spotted()
//    {

        

//        Vector3 direction = player.position - npc.transform.position;

//        if (direction.magnitude < 100f)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }

//        //float angle = Vector3.Angle(direction, npc.transform.forward);

//            //if(direction.magnitude < VisDist && angle < VisAngle)
//            //{
//            //    return true;
//            //}
//            //return false;
//    }

//    public bool CanAttackPlayer()
//    {
//        Vector3 direction = player.position - npc.transform.position;

//        if (direction.magnitude < punchDist)
//        {
//            return true;
//        }

//        return false;
//    }

//}

