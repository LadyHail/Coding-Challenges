/*
 DESCRIPTION:
 Each day a plant is growing by upSpeed meters. Each night that plant's height decreases by downSpeed meters due to the lack of sun heat. 
 Initially, plant is 0 meters tall. We plant the seed at the beginning of a day. 
 We want to know when the height of the plant will reach a certain level.
 Example:
 For upSpeed = 100, downSpeed = 10, and desiredHeight = 910, the output should be
 growingPlant(upSpeed, downSpeed, desiredHeight) = 10.
 */

namespace Main.CodeFights
{
    public static class GrowingPlant
    {
        public static int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int days = 0;
            int height = 0;
            while (height < desiredHeight)
            {
                height += upSpeed;
                days++;
                if (height < desiredHeight)
                {
                    height -= downSpeed;
                }
            }

            return days;
        }
    }
}
