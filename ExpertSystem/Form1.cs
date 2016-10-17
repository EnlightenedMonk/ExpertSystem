using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Form1 : Form
    {

        List<Node> Nodes = new List<Node>();


        public int activeNode = 0;

        public String errorFile = @"img\ErrorFile.png";
        public String none = @"img/None.png";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load the list of nodes
            Nodes.Add(new Node(1,6,"Czy podążasz drogą światła?"));//0
            Nodes.Add(new Node(2,3,"Czy walczysz wręcz?"));//1
            Nodes.Add(new Node(21,22,"Czy przyjmujesz na siebie obrażenia wroga?"));//2
            Nodes.Add(new Node(23,4,"Czy przyzywasz sojusznicze oddziały?"));//3
            Nodes.Add(new Node(24,5,"Czy masz zdolności leczenia?"));//4
            Nodes.Add(new Node(25,26,"Czy posługujesz się runami w walce?"));//5
            Nodes.Add(new Node(7,13,"Czy podążasz drogą ciemności?"));//6
            Nodes.Add(new Node(8,11,"Czy walczysz wręcz?"));//7
            Nodes.Add(new Node(27,9,"Czy używasz trucizn i związków chemicznych?"));//8
            Nodes.Add(new Node(10,30,"Czy lubisz zabijać po cichu?"));//9
            Nodes.Add(new Node(28,29,"Czy lubisz kraść?"));//10
            Nodes.Add(new Node(12,33,"Czy posługujesz się magią?"));//11
            Nodes.Add(new Node(31,32,"Czy potrafisz wskrzeszać?"));//12
            Nodes.Add(new Node(14,16,"Czy walczysz wręcz?"));//13
            Nodes.Add(new Node(34,15,"Czy dzierżysz broń w obydwu rękach?"));//14
            Nodes.Add(new Node(35,36,"Czy używasz tarczy?"));//15
            Nodes.Add(new Node(17,20,"Czy posługujesz się magią?"));//16
            Nodes.Add(new Node(37,18,"Czy używasz zaklęć destrukyjnych?"));//17
            Nodes.Add(new Node(38,19,"Czy używasz zaklęć wzmacniających?"));//18
            Nodes.Add(new Node(39,40,"Czy używasz zaklęć zamrażających?"));//19
            Nodes.Add(new Node(41,42,"Czy potrafisz tropić swoje ofiary?"));//20
            // ===========================================================
            Nodes.Add(new Node(@"img\Paladyn.png", "Paladyn"));//21
            Nodes.Add(new Node(@"img\SwietyRycerz.png", "Święty Rycerz"));//22
            Nodes.Add(new Node(@"img\Druid.png","Druid"));//23
            Nodes.Add(new Node(@"img\Kaplan.png", "Kapłan"));//24
            Nodes.Add(new Node(@"img\LowcaDemonow.png", "Łowca demonów"));//25
            Nodes.Add(new Node(@"img\Kleryk.png", "Kleryk"));//26
            Nodes.Add(new Node(@"img\Alchemik.png", "Alchemik"));//27
            Nodes.Add(new Node(@"img\Lotr.png", "Łotr"));//28
            Nodes.Add(new Node(@"img\Zabojca.png", "Zabójca"));//29
            Nodes.Add(new Node(@"img\RycerzSmierci.png", "Rycesz śmierci"));//30
            Nodes.Add(new Node(@"img\Nekromanta.png", "Nekromanta"));//31
            Nodes.Add(new Node(@"img\Czarnoksieznik.png", "Czarnoksiężnik"));//32
            Nodes.Add(new Node(@"img\PrzekletyLowca.png", "Przeklęty łowca"));//33
            Nodes.Add(new Node(@"img\Berserker.png", "Berserker"));//34
            Nodes.Add(new Node(@"img\Wojownik.png", "Wojownik"));//35
            Nodes.Add(new Node(@"img\Najemnik.png", "Najemnik"));//36
            Nodes.Add(new Node(@"img\MagOgnia.png", "Mag ognia"));//37
            Nodes.Add(new Node(@"img\MagZiemi.png", "Mag ziemi"));//38
            Nodes.Add(new Node(@"img\MagWody.png", "Mag wody"));//39
            Nodes.Add(new Node(@"img\MagPowietrza.png", "Mag powietrza"));//40
            Nodes.Add(new Node(@"img\Lowca.png", "Łowca"));//41
            Nodes.Add(new Node(@"img\Strzelec.png", "Strzelec"));//42

            picResult.Image = Image.FromFile(none);

            update();
        }

        private void update()
        {
            if (activeNode < 21)
            {
                txtQuestion.Text = String.Empty;
                txtQuestion.Text = Nodes[activeNode].text.ToString();

                txtQuestion.Text = String.Empty;
                txtQuestion.Text = Nodes[activeNode].text.ToString();
            }
            else
            {
                btnNo.Enabled = false;
                btnYes.Enabled = false;

                txtQuestion.Text = Nodes[activeNode].text.ToString();

                txtQuestion.Text = Nodes[activeNode].text.ToString();

                if (Nodes[activeNode].file != String.Empty && File.Exists(Nodes[activeNode].file))
                {
                    picResult.Image = Image.FromFile(Nodes[activeNode].file);
                }
                else
                {
                    picResult.Image = Image.FromFile(errorFile);
                }
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            activeNode = Nodes[activeNode].yes;
            update();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            activeNode = Nodes[activeNode].no;
            update();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            activeNode = 0;
            picResult.Image = null;
            btnNo.Enabled = true;
            btnYes.Enabled = true;
            picResult.Image = Image.FromFile(none);
            update();
        }
    }
}
