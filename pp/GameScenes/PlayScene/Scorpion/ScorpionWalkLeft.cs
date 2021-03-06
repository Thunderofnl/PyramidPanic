﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;


namespace pp
{
    public class ScorpionWalkLeft : AnimatedSprite, IState
    {
        //Fields
        private Scorpion scorpion;

        //Properties
       
        //Constructor
        public ScorpionWalkLeft(Scorpion scorpion)
            : base(scorpion)
        {
            this.scorpion = scorpion;
            this.currentFrame = 0;
            this.angle = 2f;
        }

        //Update       
        public override void Update(GameTime gameTime)
        {
            float elapsed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            this.scorpion.Location -= new Vector2(this.scorpion.Speed * elapsed, 0f);
            if ( this.scorpion.Location.X < this.scorpion.LeftBorder || ScorpionManager.CdMovingBlockScorpionGoingLeft(this.scorpion)) 
                    this.scorpion.IState = new ScorpionWalkRight(this.scorpion);
            base.Update(gameTime);
        }

        //Draw
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
