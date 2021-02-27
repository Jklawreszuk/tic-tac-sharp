
using Microsoft.AspNetCore.Components;

namespace tic_tac_sharp.Shared
{
    public partial class Field
    {
        [Parameter]
        public bool IsFirst { get; set; }
        [Parameter]
        public int Pos { get; set; }
        [Parameter]
        public FieldState State { get; set; }

        [Parameter]
        public EventCallback<(int,FieldState)> OnStateChanged { get; set; }
        string current = string.Empty;
        private void ChangeState()
        {
            FieldState ticOrTac = IsFirst?FieldState.Tic:FieldState.Tac;

            if(State==FieldState.None)
            {
                State=ticOrTac;
                current= IsFirst?"⭕":"✖";
                var info = (Pos, State);
                OnStateChanged.InvokeAsync(info);
            }

        }

    }
}