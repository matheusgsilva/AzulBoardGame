using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulBoardGame_PI.Componentes
{
    class EfeitosTela
    {
        public void FontHover(Label label)
        {
            label.Font = new Font("Algerian", 26, FontStyle.Bold);
        }

        public void FontLeave(Label label)
        {
            label.Font = new Font("Algerian", 24, FontStyle.Bold);
        }

    }
}
