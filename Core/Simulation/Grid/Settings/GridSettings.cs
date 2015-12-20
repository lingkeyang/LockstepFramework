﻿using UnityEngine;
using System.Collections;

namespace Lockstep
{
    public sealed class GridSettings
    {
        public int Width { get; private set; }

        public int Height { get; private set; }

        public long XOffset { get; private set; }

        public long YOffset { get; private set; }

        public GridSettings()
        {
            Init(256, 256, FixedMath.Create(-128), FixedMath.Create(-128));
        }

        public GridSettings(int width, int height, long xOffset, long yOffset)
        {
            Init(width, height, xOffset, yOffset);
        }

        private void Init(int width, int height, long xOffset, long yOffset)
        {
            this.Width = width;
            this.Height = height;
            this.XOffset = xOffset;
            this.YOffset = yOffset;
        }
    }
}