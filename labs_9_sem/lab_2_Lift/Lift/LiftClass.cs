using System;
using System.Linq;

namespace Lift
{
    public class LiftClass
    {
        public string model { get; }
        public int maxLoad { get; }
        public byte minFloor { get; }
        public byte maxFloor { get; }
        public bool[] CallList { get; set; }
        public double speedOneFloor { get; set; }
        public double doorsTime { get; set; }
        public byte currentFloor { get; set; }
        public byte targetFloor { get; set; }
        public States currentState { get; set; }


        public enum States
        {
            up,
            down,
            doorsOpen,
            doorsClose,
            wait
        }


        public LiftClass(string model, int maxLoad, byte minFloor, byte maxFloor, 
                         double speedOneFloor, double doorsTime, byte currentFloor = 1, 
                         States currentState = States.wait)
        {
            this.model = model;
            this.maxLoad = maxLoad;
            this.minFloor = minFloor;
            this.maxFloor = maxFloor;
            this.speedOneFloor = speedOneFloor;
            this.doorsTime = doorsTime;
            this.currentFloor = currentFloor;
            this.targetFloor = currentFloor;
            this.currentState = currentState;
            CallList = new bool[maxFloor];
        }

        public byte GetNextFloor()
        {
            switch (currentState)
            {
                case States.up:
                    for (int i = maxFloor - 1; i >= 0; i--)
                        if (CallList[i])
                        {
                            targetFloor = Convert.ToByte(i + 1);
                            return Convert.ToByte(i + 1);
                        }
                    break;

                case States.down:
                    for (int i = currentFloor - 1; i >= 0; i--)
                        if (CallList[i])
                        {
                            targetFloor = Convert.ToByte(i + 1);
                            return Convert.ToByte(i + 1);
                        }

                    break;

                case States.doorsOpen:
                    break;

                case States.doorsClose:
                    break;
               
                case States.wait:
                    if (CallList.All(p => !p))
                        return 0;
                    int floor = Array.FindIndex(CallList, w => w);
                    if (floor < currentFloor)
                        currentState = States.down;
                    else
                        currentState = States.up;
                    return GetNextFloor();
                    
                default:
                    return minFloor;

               

            }

            return minFloor;
        }

               

    }
}
