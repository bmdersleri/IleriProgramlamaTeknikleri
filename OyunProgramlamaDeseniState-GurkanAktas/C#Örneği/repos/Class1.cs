using System;

public partial class Computer
{
    private State _state = new Off();
    private void SetState(State state)
    {
        _state = state;
    }


    public void PressButton()
    {
        _state.PressButton(this)

    }
}

public partial class Computer
{
    private interface State
    {
        void PressButton(Computer computer);
    }

    private class Off : State
    {
        public void PressPowerButton(Computer computer)
        {
            computer.SetState(new On());
        }

    }

    private class On : State

    {
        private bool charging;
        public void PressPowerButton(Computer computer)
        {
            if charging()
            {
                computer.SetState(new Standby());
            }
            else
            {
                computer.SetState(new Off());
            }
        }

    }
    private class Standby : State
    { 
        public void PressPowerButton(Computer computer)
        {
            computer.SetState(new On());
        }
    }
}

