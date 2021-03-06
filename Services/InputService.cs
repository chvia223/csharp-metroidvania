using System;
using Raylib_cs;
using cse210_final_metroidvania.Casting;

namespace cse210_final_metroidvania.Services
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }

        public bool IsLeftPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT);
        }

        public bool IsRightPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT);
        }

        public bool IsSpacePressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_SPACE);
        }

        /// <summary>
        /// Gets the direction asked for by the current key presses
        /// </summary>
        /// <returns></returns>
        public Point GetDirection()
        {
            int x = 0;
            int y = 0;

            if (IsLeftPressed())
            {
                x = -1;
            }

            if (IsRightPressed())
            {
                x = 1;
            }

            if (IsSpacePressed())
            {
                y = 1;
            }
            
            return new Point(x, y);
        }

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }

}