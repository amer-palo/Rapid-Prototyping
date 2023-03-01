using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TimerDirection { CountUp, CountDown }
public class Timer : GameBehaviour<Timer>
{
    public TimerDirection timerDirection;
    public float startTime = 0;
    float currentTime;
    bool isTiming = false;
    float timeLimit = 0;
    bool hasTimieLimit = false;

    void Update()
    {
        if(!isTiming)
            return;
        //if the timerDirection == TimeDirection.CountUp, increment the current time, else decrement the current time
        currentTime = timerDirection == TimerDirection.CountUp ? currentTime += Time.deltaTime : currentTime -= Time.deltaTime;
      
    }

    /// <summary>
    /// Pauses the timer
    /// </summary>
    public void PauseTimer()
    {
        isTiming = false;
    }

    /// <summary>
    /// Resumes the timer
    /// </summary>
    public void ResumeTimer()
    {
        isTiming = true;
    }

    /// <summary>
    /// Stops the timer
    /// </summary>
    public void StopTimer()
    {
        isTiming = false;
    }

    /// <summary>
    /// Starts the tmer
    /// </summary>
    /// <param name="_startTime">The start of the timer. Defaults to 0.</param>
    /// <param name="_direction">The start of the timer. Defaults to count up.</param>
    public void StartTimer(float _startTime = 0, TimerDirection _direction = TimerDirection.CountUp)
    {
        timerDirection = _direction;
        startTime = _startTime;
        isTiming = true;
    }

    /// <summary>
    /// Starts the timer
    /// </summary>
    /// <param name="_startTime">What time to start at</param>
    /// <param name="_timelimit">What time limit</param>
    /// <param name="_hasTimeLimit">Use a time limit</param>
    /// /// <param name="_direction">The start of the timer. Defaults to count up.</param>
    public void StartTimer(float _startTime = 0, float _timelimit = 0, bool _hasTimeLimit = true, TimerDirection _direction = TimerDirection.CountUp)
    {
        timerDirection = _direction;
        hasTimieLimit = _hasTimeLimit;
        startTime = _startTime;
        timeLimit = _timelimit;
        isTiming = true;
    }

    /// <summary>
    /// Changes the direction of the timer
    /// </summary>
    /// <param name="_direction">The direction to change to</param>
    public void ChangeTimerDirection(TimerDirection _direction)
    {
        timerDirection = _direction;
    }

    /// <summary>
    /// Checks if time has expired
    /// </summary>
    /// <returns>If time has expired</returns>
    public bool TimeExpired()
    {
        if (!hasTimieLimit)
            return false;

        return timerDirection == TimerDirection.CountUp ? currentTime > timeLimit : currentTime < timeLimit;
    }

    /// <summary>
    /// Gets the current time
    /// </summary>
    /// <returns>The current timer</returns>
    public float GetTime()
    {
        return currentTime;
    }

    /// <summary>
    /// Checks if we are timing or not
    /// </summary>
    /// <returns>If we are timing</returns>
    public bool IsTiming()
    {
        return isTiming;
    }

    /// <summary>
    /// Inncrement our timer
    /// </summary>
    /// <param name="_increment">The amount to increment our timer</param>
    public void IncrementTimer(float _increment)
    {
        currentTime += _increment;
    }

    /// <summary>
    /// Decrement our timer
    /// </summary>
    /// <param name="_increment">The amount to decrement our timer</param>
    public void DecrementTimer(float _decrement)
    {
        currentTime -= _decrement;
    }
}
