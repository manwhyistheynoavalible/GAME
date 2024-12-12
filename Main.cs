using System;
using System.Collections;
using System.Collections.Generic;

public float marioFrontSpeed;
public float marioBackSpeed;
public float marioAcceleration;
public float marioAirSpeed;
public enum marioType = { small, big, fireFlower, star };
public enum marioDirection = { still, walkForward, crouch, jumpStrUp, jumpForward, JumpBackwards, running };
public enum marioStatePerson = { colliding, moving, crouch, running };
public enum marioStateLoc = { onGround, inAir, Swimming }
public enum powerUps = { Mushroom, fireFlower, star };
public enum enemys = { Gooba, GKoopa, Piranna, RKoopa, ParaKoopa, FireRing, Podoboo, Bowser, CheepCheep, Blooper, HammerBros, Lakitu, SpinyShell, BuzzyBeetle, BulletBill};

public class MarioSpeedFunc()
{
    public function marioAccelerationCalculator() 
    {
        if (marioStateLoc == inAir)
        {
            if (marioStatePerson == running)
            {
                if (marioStateLoc == inAir)
                {
                    float marioAcceleration -= 0.2;
                }
                else if(marioStateLoc == onGround)
                {
                    float marioAcceleration += 0.4;
                }
            }
            else if (marioStatePerson == moving)
            {
                if (marioStateLoc == inAir)
                {
                    float marioAcceleration -= 0.1;
                }
                else if (marioStateLoc == onGround)
                {
                    float marioAcceleration += 0.2;
                }
            }
            else if (marioStatePerson == swimming)
            {
                float marioAcceleration += 0.15;
            }
        }

    }

    public function MarioSpeedCalculator()
    {
        marioAccelerationCalculator()
        float marioBackSpeed += float marioAcceleration;
        float marioFrontSpeed += float marioAcceleration;

        if (marioFrontSpeed > 5)
        {
            float marioFrontSpeed = 5;
        }
        else if (marioFrontSpeed < 0)
        {
            float marioFrontSpeed = 0;
        }
    }

}