using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{ 
    class Mono
    {
        public string type;
        public DateTime timeCreate;
        public Transform spawnPoint;
        
        static public int CountCommands = 0;

        public Mono(string _type, Transform _spawnPoint = transform.position)
        {
            type = _type;
            timeCreate = DateTime.Now;
            spawnPoint = _spawnPoint;

            CountCommands++;
        }

    }
    
}

