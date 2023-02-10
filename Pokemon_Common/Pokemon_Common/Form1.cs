using Pokemon_Common.Pokemons;

namespace Pokemon_Common
{
    public partial class Form1 : Form
    {
        List<character> Pokemons;
        character selectedPokemon;
        character player;
        character enemy;

        private bool isCollapsed;
       
        public Form1()
        {
            InitializeComponent();

            Pokemons= new List<character>();
            Pokemons.Add(new kyurem());
            Pokemons.Add(new pikachu());
            Pokemons.Add(new charizard());
            Pokemons.Add(new ceruledge());
            Pokemons.Add(new yveltal());
        }

        private void runBtn_Click(object sender, EventArgs e)
        {                        
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = selectedPokemon = Pokemons[0];
            enemy = selectedPokemon = Pokemons[4];
        }

        private void krBtn_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.nameBox.Text = selectedPokemon.getName();
            this.label3.Text = ("What will \nKyurem do?");
            
        }

        private void pikcBtn_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.nameBox.Text = selectedPokemon.getName();
            this.label3.Text = ("What will \nPikachu do?");
        }

        private void chrBtn_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.nameBox.Text = selectedPokemon.getName();
            this.label3.Text = ("What will \nCharizard do?");
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void crlBtn_Click(object sender, EventArgs e)
        {
            selectedPokemon = Pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.nameBox.Text = selectedPokemon.getName();
            this.label3.Text = ("What will \nCeruledge do?");
            
        }

        private void atkBtn_Click(object sender, EventArgs e)
        {
            enemy.takeDamge(10, 5);
            if (enemy.hp > 0)
            {
                progressBar2.Value = Convert.ToInt32(enemy.hp);
            }
            else
            {
                progressBar2.Value = 0;
            }
            timerEndAtk.Enabled = true;
            atkBtn.Enabled = false;
            skillBtn.Enabled = false;
            pkmsBtn.Enabled = false;
            
        }

        private void pkmsBtn_Click(object sender, EventArgs e)
        {
            this.pokemonsPnl.Visible = true;
        }

        private void pokemonsPnl_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerEndAtk.Enabled = false;

            
            player.takeDamge(30, 15);
            if (player.hp > 0)
            {
                progressBar1.Value = Convert.ToInt32(player.hp);
            }
            else
            {
                progressBar1.Value = 0;
            }
            atkBtn.Enabled = true;
            skillBtn.Enabled = true;
            pkmsBtn.Enabled = true;
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.pokemonsPnl.Visible = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void skillBtn_Click(object sender, EventArgs e)
        {
            enemy.takeDamge(30, 15);
            if (enemy.hp > 0)
            {
                progressBar2.Value = Convert.ToInt32(enemy.hp);
            }
            else
            {
                progressBar2.Value = 0;
            }
            timerEndAtk.Enabled = true;
            atkBtn.Enabled = false;
            skillBtn.Enabled = false;
            pkmsBtn.Enabled = false;
            
        }
    }
}