﻿using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IL2CPU.API.Attribs;
using Mouse = Cosmos.System.MouseManager;
using MouseState = Cosmos.System.MouseState;
using Cosmos.Core.Memory;

namespace BootNet.Graphics
{
    public class Desktop
    {
        
        public static void DrawCanvas()
        {
            Kernel.canvas = new SVGAIICanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
            Kernel.canvas.Clear(Color.DarkBlue);
            
        }
       

        public static void DrawTaskBar()
        {
            Kernel.canvas.DrawFilledRectangle(new Pen(Color.FromArgb(64, 64, 64)), 0, 584, 800, 16);
            Graphics.Objects.DrawButton(new Pen(Color.FromArgb(64, 64, 64)), new Pen(Color.White), 0, 584, "Menu");
            if (Mouse.X >= 0 && Mouse.X <= 100 && Mouse.Y>=96)
            {
                Objects.DrawMenu(new Pen(Color.FromArgb(64, 64, 64)), new Pen(Color.White), 0, 504, "TestApp", "Console", "Web", "Reboot", "Shutdown");
                if (Mouse.MouseState == MouseState.Left && Mouse.Y >= 80 && Mouse.X >= 100)
                {
                    Cosmos.System.Power.Shutdown();
                }
            }
            String time = new(DateTime.Now.ToShortTimeString()) ;
            ASC16.DrawACSIIString(Kernel.canvas, new Pen(Color.White),time , 760, 584);
        }
    }
}
