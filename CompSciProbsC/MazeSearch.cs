using System;
using System.Collections.Generic;
using System.Data.Common;

namespace CompSciProbsC
{
    enum Cell
    {
        X, _, S, G, P
    }
    public class MazeSearch
    {}

    public class Maze
    {
        private int rows, columns;
        private MazeLocation start, goal;
        private Cell[,] grid;

        public Maze(int rows, int columns, MazeLocation start, MazeLocation goal)
        {
            this.rows = rows;
            this.columns = columns;
            this.start = start;
            this.goal = goal;
            grid = new Cell[rows, columns];
            foreach (var c in grid)
            {
                c = Cell._;
            }
            
        }

    }
    
    public class MazeLocation{
        
        public readonly int row, column;

        public MazeLocation(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        public static IEqualityComparer<MazeLocation> RowColumnComparer { get; } = new RowColumnEqualityComparer();

        private sealed class RowColumnEqualityComparer : IEqualityComparer<MazeLocation>
        {
            public bool Equals(MazeLocation x, MazeLocation y)
            {
                if (ReferenceEquals(x, y)) return true;
                if (ReferenceEquals(x, null)) return false;
                if (ReferenceEquals(y, null)) return false;
                if (x.GetType() != y.GetType()) return false;
                return x.row == y.row && x.column == y.column;
            }

            public int GetHashCode(MazeLocation obj)
            {
                return HashCode.Combine(obj.row, obj.column);
            }
        }
    }
}
