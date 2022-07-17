using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSingle : MonoBehaviour
{
    [SerializeField]
    private LogManager lManager;
    private static LogSingle instance;
        public static LogSingle Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new LogSingle();
                }
                return instance;
            }
        }

    private LogSingle(){
        lManager = GetComponent<LogManager>();
    }
    
    public LogManager getLogManager(){
        return lManager;
    }

}