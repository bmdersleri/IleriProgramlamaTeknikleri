using System;

void Main()
{

}


public class Computer
{

    private int state = 0;
    private bool charging = true;

    public void PressPowerButton()
    {

        //off
        if (state == 0)
        {
            state = 1;
            return;
        }

        //on
        if ( state == 1)
        {

            if (charging)
            {
                state = 2;
                return;
            }
            state = 0;
            return;

        }

        state = 1;
    }
}