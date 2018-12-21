using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public interface IDriveable
    {
        double Move(int soldierAmount, int landDistance);
    }
}
