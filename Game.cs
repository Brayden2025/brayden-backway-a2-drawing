// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Vector2[] bubblePositions = { new Vector2(200, 430), new Vector2(230, 420), new Vector2 (260, 440),
            new Vector2 (200, 400), };

        public void Setup()
        {
            Window.SetSize(800,600);
        }

        public void Update()
        {
            Window.ClearBackground(Color.White);

            //Draw Bubble Machine
            Draw.FillColor = Color.LightGray;
            Draw.Rectangle(0, 400, 150, 100);

            //Draw Ground
            Draw.FillColor = Color.Green;
            Draw.Rectangle(0, 500, 800, 100);

            Draw.FillColor = Color.Blue;
            foreach (var bubble in bubblePositions)
            {
                Draw.Circle(bubble, 11);
            }
        }
    }

}
