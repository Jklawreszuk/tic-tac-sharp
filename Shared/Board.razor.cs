using System.Collections.Generic;

namespace tic_tac_sharp.Shared
{
    public partial class Board
    {
        FieldState[] matrix;
        public bool isFirst = true;
        FieldState winner;
        const int size = 9;
        public Board()=>matrix = new FieldState[size];
        readonly List<int>[] victorySolutions = new List<int>[]{
                new (){0,1,2},new(){3,4,5},new(){6,7,8},
                new (){0,3,6},new(){1,4,7},new(){2,5,8},
                new (){0,4,8},new(){2,4,6}
        };
        public void ChangeState((int,FieldState) field)
        {
            if (!IsVictoryAchieved())
            {
                isFirst = !isFirst;
                matrix[field.Item1] = field.Item2;
            }
        }

        public bool IsVictoryAchieved()
        {
            
            foreach(var solution in victorySolutions)
            {
                if(matrix[solution[0]] != FieldState.None &&
                    matrix[solution[0]] == matrix[solution[1]] &&
                    matrix[solution[0]] == matrix[solution[2]])
                {
                    winner = matrix[solution[0]];
                    return true;
                }
            }

            return false;
        }
    }
}