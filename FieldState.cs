using Humanizer;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace tic_tac_sharp
{
    public enum FieldState
    {

        None,
        [Description("K�ko")]
        Tic,
        [Description("Krzy�yk")]
        Tac
    }
}