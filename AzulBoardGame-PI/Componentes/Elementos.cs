using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AzulBoardGame_PI
{
    class Elementos
    {

        public void MontarPecas(Form form, string control, string azuleijo)
        {

            var found = form.Controls.Find(control, true);
            if (found.Count() > 0)
                found[0].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(azuleijo);
        }

        public void OcultarPecas(Form form)
        {
            string[] controls = { "l1a1", "l2a1", "l2a2", "l3a1", "l3a2", "l3a3", "l4a1", "l4a2", "l4a3", "l4a4", "l5a1", "l5a2", "l5a3", "l5a4", "l5a5" };
            foreach (var control in controls)
            {
                var found = form.Controls.Find(control, true);
                if (found.Count() > 0)
                    found[0].BackgroundImage = null;
            }

        }

        public void OcultarCentro(Form form)
        {
            string[] controls = { "centro1", "centro2", "centro3", "centro4", "centro5", "centro6", "centro7", "centro8", "centro9",
               "centro10", "centro11", "centro12", "centro13", "centro14", "centro15", "centro16", "centro17", "centro18",
               "centro19", "centro20", "centro21", "centro22", "centro23", "centro24", "centro25", "centro26", "centro27",
               "centro28", "centro29", "centro30", "centro31", "centro32"};
            foreach (var control in controls)
            {
                var found = form.Controls.Find(control, true);
                if (found.Count() > 0)
                    found[0].BackgroundImage = null;
            }

        }

        public void OcultarChao(Form form)
        {
            string[] controls = { "c1", "c2", "c3", "c4", "c5", "c6", "c7"};
            foreach (var control in controls)
            {
                var found = form.Controls.Find(control, true);
                if (found.Count() > 0)
                    found[0].BackgroundImage = null;
            }

        }

        public void OcultarFabricas(Form form)
        {
            string[] controls = { "p1", "p2", "p3", "p4", "p5", "p6", "p7", "p8", "p9", "p10", "p11", "p12",
            "p13", "p14", "p15", "p16", "p17", "p18", "p19", "p20", "p21", "p22", "p23", "p24",
            "p25", "p26", "p27", "p28", "p29", "p30", "p31", "p32", "p33", "p34", "p35", "p36"};
            foreach (var control in controls)
            {
                var found = form.Controls.Find(control, true);
                if (found.Count() > 0)
                    found[0].BackgroundImage = null;
            }

        }
    }
}
