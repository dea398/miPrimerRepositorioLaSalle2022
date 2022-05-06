﻿using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiJuegoUnoLaSalle2022
{
    class Sprite
    {
        
        private string sourceImageName;

        protected Texture2D texture2D;

        protected Rectangle rectangle;

        public Rectangle MyRectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }


        private Point location;

        public Point Location
        {
            get 
            { 
                return location; 
            }
            set 
            { 
                location = value; 
            }
        }

        private Point size;

        public Point Size
        {
            get { return size; }
            set { size = value; }
        }

        public string SourceImageName 
        { 
            get 
            { 
                return this.sourceImageName; 
            } 
        }

       
        /// <summary>
        /// OJO: If you call this overloaded constructor you wont be able to change it later
        /// In fact, you will have a default image displaying 'No Image'
        /// </summary>
        public Sprite():this("NoImage")
        { 
            
        }

        /// <summary>
        /// Overloaded Constructor receiving the name of the external resource
        /// </summary>
        /// <param name="sourceImageName"> String representing the name of the external resource </param>
        public Sprite(string sourceImageName)
            :this(sourceImageName,new Point(0,0),new Point(20,20))
        {
            
        }

        /// <summary>
        /// Overloaded Constructor receiving name of the external resource, location and size
        /// </summary>
        /// <param name="sourceImageName">String representing the name of the external resource</param>
        /// <param name="location">Class Point representing the x and y position on the screen</param>
        /// <param name="size">Class Point representing width and height of the sprite </param>
        public Sprite(string sourceImageName, Point location, Point size)
        {
            this.sourceImageName = sourceImageName;
            this.location = location;
            this.size = size;
            this.rectangle = new Rectangle(this.Location,this.Size);
        }

        /// <summary>
        /// This method must be called to load an external asset to the RAM Memory
        /// </summary>
        /// <param name="contentManager">Send the principal content manager of the Game</param>
        public void LoadContent(ContentManager contentManager)
        {
            try
            {
                this.texture2D = contentManager.Load<Texture2D>(this.sourceImageName);
            }
            catch (Exception)
            {
                throw new Exception("This is a custom message error");
            }

            try
            {
                //Codigo que intenta conectarse a la base de datos
            }
            catch (Exception)
            {
                //codigo donde personalizo el error que quiero mostrar según la excepción detectada
            }
            finally
            {
                // sea que exista un error o no, siempre este bloque debe ejecutarse
            }
            
        }

        /// <summary>
        /// This method should be called to draw the sprite on the screen
        /// </summary>
        /// <param name="spriteBatch">Send the principal Spritebatch of the Game</param>
        /// <param name="color">Specify in which background color the image will be drawn</param>
        public virtual void Draw(SpriteBatch spriteBatch, Color color)
        {
            this.rectangle.Location = this.Location;
            spriteBatch.Draw(this.texture2D, this.rectangle, color);

        }
        
    }

}
