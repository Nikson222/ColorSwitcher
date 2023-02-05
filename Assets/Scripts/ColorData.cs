using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ColorsLibrary
{
    public static class ColorData
    {
        private static List<Color> colors = new List<Color>()
    {
        {new Color(0, 0, 255, 255) },
        {new Color(255, 0, 217, 255) },
        {new Color(255, 228, 0, 255) },
        {new Color(0, 255, 0, 255) }
    };

        public static Color GetRandomColor()
        {
            int randomIndex = Random.Range(0, colors.Count);

            return colors[randomIndex];
        }

        public static Color GetColor(Colors color)
        {
            switch (color)
            {
                case Colors.Blue:
                    return colors[0];
                case Colors.Pink:
                    return colors[1];
                case Colors.Yellow:
                    return colors[2];
                case Colors.Green:
                    return colors[3];
                default:
                    return colors[0];
            }
        }
    }

    public enum Colors
    {
        Blue,
        Green,
        Yellow,
        Pink
    }
}
