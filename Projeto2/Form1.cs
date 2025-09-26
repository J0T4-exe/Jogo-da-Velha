namespace Projeto2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public class Global()
        {
            public static bool turn, btn_trava;
            public static int rounds = 0, A = 0, B = 0, C = 0, D = 0, E = 0, F = 0, G = 0, H = 0, I = 0;
        }
        private void ComputadorJogar()
        {
            if (Global.btn_trava == true) return; // se o jogo acabou, não joga

            Random rnd = new Random();
            bool jogou = false;

            while (!jogou)
            {
                int pos = rnd.Next(1, 10); // sorteia de 1 a 9

                switch (pos)
                {
                    case 1:
                        if (Global.A == 0)
                        {
                            btn11.Text = "O";
                            Global.A = 2;
                            jogou = true;
                        }
                        break;
                    case 2:
                        if (Global.B == 0)
                        {
                            btn12.Text = "O";
                            Global.B = 2;
                            jogou = true;
                        }
                        break;
                    case 3:
                        if (Global.C == 0)
                        {
                            btn13.Text = "O";
                            Global.C = 2;
                            jogou = true;
                        }
                        break;
                    case 4:
                        if (Global.D == 0)
                        {
                            btn21.Text = "O";
                            Global.D = 2;
                            jogou = true;
                        }
                        break;
                    case 5:
                        if (Global.E == 0)
                        {
                            btn22.Text = "O";
                            Global.E = 2;
                            jogou = true;
                        }
                        break;
                    case 6:
                        if (Global.F == 0)
                        {
                            btn23.Text = "O";
                            Global.F = 2;
                            jogou = true;
                        }
                        break;
                    case 7:
                        if (Global.G == 0)
                        {
                            btn31.Text = "O";
                            Global.G = 2;
                            jogou = true;
                        }
                        break;
                    case 8:
                        if (Global.H == 0)
                        {
                            btn32.Text = "O";
                            Global.H = 2;
                            jogou = true;
                        }
                        break;
                    case 9:
                        if (Global.I == 0)
                        {
                            btn33.Text = "O";
                            Global.I = 2;
                            jogou = true;
                        }
                        break;
                }
            }
            Global.rounds++;
            Global.turn = false; // volta a vez para o jogador
            exibir_winner();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.A == 0)
            {
                btn11.Text = "X";
                Global.A = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }
        }


        

        private void btn12_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.B == 0)
            {
                btn12.Text = "X";
                Global.B = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }

        }
        private void btn13_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.C == 0)
            {
                btn13.Text = "X";
                Global.C = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.D == 0)
            {
                btn21.Text = "X";
                Global.D = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.E == 0)
            {
                btn22.Text = "X";
                Global.E = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }

        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.F == 0)
            {
                btn23.Text = "X";
                Global.F = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }

        }
        

        private void btn33_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.G == 0)
            {
                btn33.Text = "X";
                Global.G = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.H == 0)
            {
                btn32.Text = "X";
                Global.H = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }

        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (Global.turn == false && Global.btn_trava == false && Global.I == 0)
            {
                btn31.Text = "X";
                Global.I = 1;
                Global.rounds++;
                Global.turn = true;
                exibir_winner();
                if (!Global.btn_trava)
                {
                    ComputadorJogar();
                }
            }
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jogo Reiniciado!");
            Global.rounds = 0;
            btn11.Text = "";
            Global.A = 0;
            btn12.Text = "";
            Global.B = 0;
            btn13.Text = "";
            Global.C = 0;
            Global.D = 0;
            btn21.Text = "";
            Global.D = 0;
            Global.E = 0;
            btn22.Text = "";
            Global.E = 0;
            Global.F = 0;
            btn23.Text = "";
            Global.F = 0;
            Global.G = 0;
            btn31.Text = "";
            Global.G = 0;
            Global.H = 0;
            btn32.Text = "";
            Global.H = 0;
            Global.I = 0;
            btn33.Text = "";
            Global.I = 0;
        }
        private void exibir_winner()
        {
            if (Global.A == 1 && Global.B == 1 && Global.C == 1 || Global.A == 1 && Global.D == 1 && Global.G == 1 || Global.A == 1 && Global.E == 1 && Global.I == 1 || Global.D == 1 && Global.E == 1 && Global.F == 1 || Global.G == 1 && Global.H == 1 && Global.I == 1 || Global.C == 1 && Global.E == 1 && Global.G == 1 || Global.B == 1 && Global.E == 1 && Global.H == 1 || Global.C == 1 && Global.F == 1 && Global.I == 1)
            {
                MessageBox.Show("Jogador X Ganhou!");
                Global.rounds = 0;
                btn11.Text = "";
                Global.A = 0;
                btn12.Text = "";
                Global.B = 0;
                btn13.Text = "";
                Global.C = 0;
                Global.D = 0;
                btn21.Text = "";
                Global.D = 0;
                Global.E = 0;
                btn22.Text = "";
                Global.E = 0;
                Global.F = 0;
                btn23.Text = "";
                Global.F = 0;
                Global.G = 0;
                btn31.Text = "";
                Global.G = 0;
                Global.H = 0;
                btn32.Text = "";
                Global.H = 0;
                Global.I = 0;
                btn33.Text = "";
                Global.I = 0;

        } else if (Global.rounds==9)
            {
                MessageBox.Show("JOGO EMPATADO!");
            }
        if (Global.A == 2 && Global.B == 2 && Global.C == 2 || Global.A == 2 && Global.D == 2 && Global.G == 2 || Global.A == 2 && Global.E == 2 && Global.I == 2 || Global.D == 2 && Global.E == 2 && Global.F == 2 || Global.G == 2 && Global.H == 2 && Global.I == 2 || Global.C == 2 && Global.E == 2 && Global.G == 2 || Global.B == 2 && Global.E == 2 && Global.H == 2 || Global.C == 2 && Global.F == 2 && Global.I == 2)
            {
                MessageBox.Show("Jogador O Ganhou!");

                Global.rounds = 0;
                btn11.Text = "";
                Global.A = 0;
                btn12.Text = "";
                Global.B = 0;
                btn13.Text = "";
                Global.C = 0;
                Global.D = 0;
                btn21.Text = "";
                Global.D = 0;
                Global.E = 0;
                btn22.Text = "";
                Global.E = 0;
                Global.F = 0;
                btn23.Text = "";
                Global.F = 0;
                Global.G = 0;
                btn31.Text = "";
                Global.G = 0;
                Global.H = 0;
                btn32.Text = "";
                Global.H = 0;
                Global.I = 0;
                btn33.Text = "";
                Global.I = 0;
            }
            else if (Global.rounds == 9)
            {
                MessageBox.Show("JOGO EMPATADO!");
            }

        }
    }
}
