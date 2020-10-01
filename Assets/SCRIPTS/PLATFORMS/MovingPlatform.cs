using System;

namespace PLATFORMS
{
    [Serializable]
    public class MovingPlatform : BasePlatform
    {
        public enum MovementType
        {
            UpDown,
            LeftRight
        }

        public MovementType movementType = MovementType.LeftRight;
        public int movementAmount = 5;
    }
}